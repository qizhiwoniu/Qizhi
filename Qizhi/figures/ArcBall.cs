using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Cameras;
using SharpGL.SceneGraph.Core;
using SharpGL.SceneGraph.Effects;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph.Primitives;
using SharpGL.SceneGraph.Quadrics;
using System;
using System.Drawing;
using System.Windows.Forms;
using Qizhi.figures;
using Assimp;
using Camera = SharpGL.SceneGraph.Cameras.Camera;

namespace Qizhi.figures
{
    [Serializable()]
    class ArcBall
    {
        bool mouseDownFlag;
        private figures.ArcBallEffect objectArcBallEffect;
        private figures.ArcBallEffect axisArcBallEffect;
        const float near = 0.01f;
        const float far = 10000;
        
        float _angle, _length, _radiusRadius;
        double[] _lastTransform = new Double[16] { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 };
        Vertex _startPosition, _endPosition, _normalVector = new Vertex(0, 1, 0);
        int _width;
        int _height;

        public ArcBall(float eyex, float eyey, float eyez,
            float centerx, float centery, float centerz,
            float upx, float upy, float upz)
        {
            SetCamera(eyex, eyey, eyez, centerx, centery, centerz, upx, upy, upz);
        }
        public void SetBounds(int width, int height)
        {
            this._width = width; this._height = height;
            _length = width > height ? width : height;
            var rx = (width / 2) / _length;
            var ry = (height / 2) / _length;
            _radiusRadius = (float)(rx * rx + ry * ry);
        }

        public void MouseDown(int x, int y)
        {
            this._startPosition = GetArcBallPosition(x, y);

            mouseDownFlag = true;
        }

        private Vertex GetArcBallPosition(int x, int y)
        {
            var rx = (x - _width / 2) / _length;
            var ry = (_height / 2 - y) / _length;
            var zz = _radiusRadius - rx * rx - ry * ry;
            var rz = (zz > 0 ? Math.Sqrt(zz) : 0);
            var result = new Vertex(
                (float)(rx * _vectorRight.X + ry * _vectorUp.X + rz * _vectorCenterEye.X),
                (float)(rx * _vectorRight.Y + ry * _vectorUp.Y + rz * _vectorCenterEye.Y),
                (float)(rx * _vectorRight.Z + ry * _vectorUp.Z + rz * _vectorCenterEye.Z)
                );
            return result;
        }


        public void MouseMove(int x, int y)
        {
            if (mouseDownFlag)
            {
                this._endPosition = GetArcBallPosition(x, y);
                var cosAngle = _startPosition.ScalarProduct(_endPosition) / (_startPosition.Magnitude() * _endPosition.Magnitude());
                if (cosAngle > 1) { cosAngle = 1; }
                else if (cosAngle < -1) { cosAngle = -1; }
                var angle = 10 * (float)(Math.Acos(cosAngle) / Math.PI * 180);
                System.Threading.Interlocked.Exchange(ref _angle, angle);
                _normalVector = _startPosition.VectorProduct(_endPosition);
                _startPosition = _endPosition;
            }
        }

        public void MouseUp(int x, int y)
        {
            mouseDownFlag = false;
        }

        public void TransformMatrix(OpenGL gl)
        {
            gl.PushMatrix();
            gl.LoadIdentity();
            gl.Rotate(2 * _angle, _normalVector.X, _normalVector.Y, _normalVector.Z);
            System.Threading.Interlocked.Exchange(ref _angle, 0);
            gl.MultMatrix(_lastTransform);
            gl.GetDouble(SharpGL.Enumerations.GetTarget.ModelviewMatix, _lastTransform);
            gl.PopMatrix();
            gl.Translate(_translateX, _translateY, _translateZ);
            gl.MultMatrix(_lastTransform);
            gl.Scale(Scale, Scale, Scale);
        }

        /// <summary>
        /// Default camera is at positive Z axis to look at negtive Z axis with up vector to positive Y axis.
        /// </summary>
        /// <param name="eyex"></param>
        /// <param name="eyey"></param>
        /// <param name="eyez"></param>
        /// <param name="centerx"></param>
        /// <param name="centery"></param>
        /// <param name="centerz"></param>
        /// <param name="upx"></param>
        /// <param name="upy"></param>
        /// <param name="upz"></param>
        public void SetCamera(float eyex, float eyey, float eyez,
            float centerx, float centery, float centerz,
            float upx, float upy, float upz)
        {
            _vectorCenterEye = new Vertex(eyex - centerx, eyey - centery, eyez - centerz);
            _vectorCenterEye.Normalize();
            _vectorUp = new Vertex(upx, upy, upz);
            _vectorRight = _vectorUp.VectorProduct(_vectorCenterEye);
            _vectorRight.Normalize();
            _vectorUp = _vectorCenterEye.VectorProduct(_vectorRight);
            _vectorUp.Normalize();
        }

        public void GoUp(float interval)
        {
            this._translateX += this._vectorUp.X * interval;
            this._translateY += this._vectorUp.Y * interval;
            this._translateZ += this._vectorUp.Z * interval;
        }
        public void GoDown(float interval)
        {
            this._translateX -= this._vectorUp.X * interval;
            this._translateY -= this._vectorUp.Y * interval;
            this._translateZ -= this._vectorUp.Z * interval;
        }
        public void GoLeft(float interval)
        {
            this._translateX -= this._vectorRight.X * interval;
            this._translateY -= this._vectorRight.Y * interval;
            this._translateZ -= this._vectorRight.Z * interval;
        }
        public void GoRight(float interval)
        {
            this._translateX += this._vectorRight.X * interval;
            this._translateY += this._vectorRight.Y * interval;
            this._translateZ += this._vectorRight.Z * interval;
        }
        /// <summary>
        /// 俯视图
        /// </summary>
        /// <param name="interval"></param>
        public void VerticalView(float interval)
        {
            this._translateX += this._vectorUp.X * interval;
        }
        /// <summary>
        /// 主视图
        /// </summary>
        /// <param name="interval"></param>
        public void FrontView(float interval) {
            OrthographicCamera camera = new OrthographicCamera();

            // 设置正交投影模式
            camera.AspectRatio = 1.0f; // 设置宽高比
            camera.Position = new SharpGL.SceneGraph.Vertex(0, 0, 10);  // 设置相机位置，例如在z轴上离原点10个单位的位置
            camera.Left = -5.0f; // 设置左边界
            camera.Right = 5.0f; // 设置右边界
            camera.Bottom = -5.0f; // 设置底部边界
            camera.Top = 5.0f; // 设置顶部边界
            
        }
        /// <summary>
        /// 顶视图
        /// </summary>
        /// <param name="interval"></param>
        public void TopView(float interval)
        {
            OrthographicCamera camera = new OrthographicCamera();

            // 设置正交投影模式
            camera.AspectRatio = 1.0f; // 设置宽高比
            camera.Position = new SharpGL.SceneGraph.Vertex(0, 0, 10);  // 设置相机位置，例如在z轴上离原点10个单位的位置
            camera.Left = -5.0f; // 设置左边界
            camera.Right = 5.0f; // 设置右边界
            camera.Bottom = -5.0f; // 设置底部边界
            camera.Top = 5.0f; // 设置顶部边界

        }
        /// <summary>
        /// 空格键
        /// </summary>
        /// <param name="interval"></param>
        public void Space(float interval)
        {
            /// 获取plane中点并设置
            this._translateX += this._vectorRight.X * 3;
            this._translateY += this._vectorRight.Y * 3;
            this._translateZ += this._vectorRight.Z * 3;
        }
        /// <summary>
        /// Alt键
        /// </summary>
        internal void Alt(object sender)
        {
              this.mouseDownFlag = true;
            
        }
        /// <summary>
        /// 设置轴线
        /// </summary>
        public void Axiesline(float interval)
        {
            ///x轴
            ///y轴
            var folder = new SharpGL.SceneGraph.Primitives.Folder() { Name = "Axis" };
           
            SharpGL.SceneGraph.Assets.Material red = new SharpGL.SceneGraph.Assets.Material();
            red.Emission = Color.Red;
            red.Diffuse = Color.Red;

            Cylinder x1 = new Cylinder() { Name = "X1" };
            x1.BaseRadius = 0.05;
            x1.TopRadius = 0.05;
            x1.Height = 1.5;
            x1.Transformation.RotateY = 90f;
            x1.Material = red;
            folder.AddChild(x1);


            Cylinder x2 = new Cylinder() { Name = "X2" };
            x2.BaseRadius = 0.1;
            x2.TopRadius = 0;
            x2.Height = 0.2;
            x2.Transformation.TranslateX = 1.5f;
            x2.Transformation.RotateY = 90f;
            x2.Material = red;
            folder.AddChild(x2);

            // Y轴
            SharpGL.SceneGraph.Assets.Material green = new SharpGL.SceneGraph.Assets.Material();
            green.Emission = Color.Green;
            green.Diffuse = Color.Green;

            Cylinder y1 = new Cylinder() { Name = "Y1" };
            y1.BaseRadius = 0.05;
            y1.TopRadius = 0.05;
            y1.Height = 1.5;
            y1.Transformation.RotateX = -90f;
            y1.Material = green;
            folder.AddChild(y1);

            Cylinder y2 = new Cylinder() { Name = "Y2" };
            y2.BaseRadius = 0.1;
            y2.TopRadius = 0;
            y2.Height = 0.2;
            y2.Transformation.TranslateY = 1.5f;
            y2.Transformation.RotateX = -90f;
            y2.Material = green;
            folder.AddChild(y2);

            // Z轴
            SharpGL.SceneGraph.Assets.Material blue = new SharpGL.SceneGraph.Assets.Material();
            blue.Emission = Color.Blue;
            blue.Diffuse = Color.Blue;

            Cylinder z1 = new Cylinder() { Name = "Z1" };
            z1.BaseRadius = 0.05;
            z1.TopRadius = 0.05;
            z1.Height = 1.5;
            z1.Material = blue;
            folder.AddChild(z1);

            Cylinder z2 = new Cylinder() { Name = "Z2" };
            z2.BaseRadius = 0.1;
            z2.TopRadius = 0;
            z2.Height = 0.2;
            z2.Transformation.TranslateZ = 1.5f;
            z2.Material = blue;
            folder.AddChild(z2);
        }

        float _translateZ;
        float _translateY;
        float _translateX;

        private float _scale = 1.0f;
        private Vertex _vectorCenterEye;
        private Vertex _vectorUp;
        private Vertex _vectorRight;
        public float Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }


        public void SetTranslate(double x, double y, double z)
        {
            this._translateX = (float)x;
            this._translateY = (float)y;
            this._translateZ = (float)z;
        }

        public void GoFront(int interval)
        {
            this._translateX -= this._vectorCenterEye.X * interval;
            this._translateY -= this._vectorCenterEye.Y * interval;
            this._translateZ -= this._vectorCenterEye.Z * interval;
        }
        public void GoBack(int interval)
        {
            this._translateX += this._vectorCenterEye.X * interval;
            this._translateY += this._vectorCenterEye.Y * interval;
            this._translateZ += this._vectorCenterEye.Z * interval;
        }
    }

}

