using Assimp;
using Qizhi.figures;
using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Cameras;
using SharpGL.SceneGraph.Core;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Qizhi
{
    public partial class DrawWindow : DockContent
    {
        private figures.ArcBallEffect objectArcBallEffect;
        private figures.ArcBallEffect axisArcBallEffect;
        private AssimpContext assimpContext;
        private Assimp.Scene scene;

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem menuItem1;
        private ToolStripMenuItem menuItem2;

        const float near = 0.01f;
        const float far = 10000;
        private bool mouseDownLeft;
        public DrawWindow()
        {
            InitializeComponent();
            sceneControl.MouseWheel += SceneControl_MouseWheel;
            AutoScaleMode = AutoScaleMode.Dpi;
            assimpContext = new AssimpContext();
            
            // 创建一个球 Create a sphere.
            /*SharpGL.SceneGraph.Quadrics.Sphere sphere = new SharpGL.SceneGraph.Quadrics.Sphere();
            sphere.Transformation.TranslateX = 1;
            sphere.Transformation.TranslateY = 1;

            sceneControl.Scene.SceneContainer.AddChild(sphere);*/
        }

        #region 右键菜单
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            // 菜单项1 的点击事件处理
            MessageBox.Show("菜单项1 被点击了！");
        }
        private void MenuItem2_Click(object sender, EventArgs e)
        {
            // 菜单项2 的点击事件处理
            MessageBox.Show("菜单项2 被点击了！");
        }
        #endregion

        public void LoadModel(string path)
        {
            scene = assimpContext.ImportFile(path, PostProcessPreset.TargetRealTimeMaximumQuality);
            sceneControl.Invalidate();
        }

        private void SceneControl_MouseWheel(Object sender, MouseEventArgs e)
        {
            objectArcBallEffect.ArcBall.Scale -= -(e.Delta * 0.001f);
            // 重新绘制场景
            sceneControl.Invalidate();
        }
        private void sceneControl_KeyDown(object sender, KeyEventArgs e)
        {
            const float interval = 1;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                this.objectArcBallEffect.ArcBall.GoUp(interval);
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                this.objectArcBallEffect.ArcBall.GoDown(interval);
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                this.objectArcBallEffect.ArcBall.GoLeft(interval);
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                this.objectArcBallEffect.ArcBall.GoRight(interval);
            }

            else if (e.KeyCode == Keys.F || e.KeyCode == Keys.F)
            {
                this.objectArcBallEffect.ArcBall.FrontView(interval);
                
            }
            else if (e.KeyCode == Keys.T || e.KeyCode == Keys.T)
            {
                this.objectArcBallEffect.ArcBall.TopView(interval);

            }

            else if (e.KeyCode == Keys.X || e.KeyCode == Keys.X)
            {
                this.objectArcBallEffect.ArcBall.Space(interval);
            }
            else if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Space)
            {
                this.objectArcBallEffect.ArcBall.Space(interval);
            }
            else if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Alt)
            {
                this.objectArcBallEffect.ArcBall.Alt(sender);
            }
        }

       
        private void sceneControl_MouseDown(object sender, MouseEventArgs e)
        {

            this.mouseDownLeft = true;
            objectArcBallEffect.ArcBall.SetBounds(this.sceneControl.Width, this.sceneControl.Height);
            objectArcBallEffect.ArcBall.MouseDown(e.X, e.Y);
            axisArcBallEffect.ArcBall.SetBounds(this.sceneControl.Width, this.sceneControl.Height);
            axisArcBallEffect.ArcBall.MouseDown(e.X, e.Y);
        }
        private void sceneControl_MouseMove(object sender, MouseEventArgs e)
        {
            objectArcBallEffect.ArcBall.MouseMove(e.X, e.Y);
            axisArcBallEffect.ArcBall.MouseMove(e.X, e.Y);
        }
        private void sceneControl_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDownLeft = false;
            objectArcBallEffect.ArcBall.MouseUp(e.X, e.Y);
            axisArcBallEffect.ArcBall.MouseUp(e.X, e.Y);
        }
        

        private void sceneControl_Load(object sender, EventArgs e)
        {

        }
        private void InitElements(SharpGL.SceneGraph.Scene scene)
        {
            var objectRoot = new SharpGL.SceneGraph.Primitives.Folder() { Name = "Root" };
            scene.SceneContainer.AddChild(objectRoot);
            // This implements free rotation(with translation and rotation).
            var camera = GetCamera();
            objectArcBallEffect = new figures.ArcBallEffect(
                camera.Position.X, camera.Position.Y, camera.Position.Z,
                camera.Target.X, camera.Target.Y, camera.Target.Z,
                camera.UpVector.X, camera.UpVector.Y, camera.UpVector.Z);
            objectRoot.AddEffect(objectArcBallEffect);
            var axisRoot = new SharpGL.SceneGraph.Primitives.Folder() { Name = "axis root" };
            scene.SceneContainer.AddChild(axisRoot);

            axisArcBallEffect = new figures.ArcBallEffect(
                camera.Position.X, camera.Position.Y, camera.Position.Z,
                camera.Target.X, camera.Target.Y, camera.Target.Z,
                camera.UpVector.X, camera.UpVector.Y, camera.UpVector.Z);
            axisRoot.AddEffect(axisArcBallEffect);



            InitAxis(objectRoot);
            InitAxis(axisRoot);
            InitFrameElement(1, 1, 1, objectRoot);
            InitGridElement(-5, -5, 0, 10, 10, objectRoot);

           
        }
        private void InitGridElement(float x, float y, float z, float width, float length, SceneElement parent)
        {
            var folder = new SharpGL.SceneGraph.Primitives.Folder() { Name = "Grid" };
            parent.AddChild(folder);

            var grid = new GridElement(x, y, z, width, length);
            folder.AddChild(grid);
        }
        private void InitFrameElement(int width, int length, int height, SceneElement parent)
        {
            var folder = new SharpGL.SceneGraph.Primitives.Folder() { Name = "Frame" };
            parent.AddChild(folder);

            var frame = new FrameElement(width, length, height);
            folder.AddChild(frame);
        }
        public void InitAxis(SceneElement parent)
        {
            var folder = new SharpGL.SceneGraph.Primitives.Folder() { Name = "Axis" };
            parent.AddChild(folder);
            folder.AddChild(new figures.Axies());




        }
        private void sceneControl_OpenGLInitialized(object sender, EventArgs e)
        {
            var scene = this.sceneControl.Scene;
            scene.SceneContainer.Children.Clear();
            scene.RenderBoundingVolumes = false;
            // 设置视角
            var camera = GetCamera();
            camera.Near = near;
            camera.Far = far;
            camera.Position = new Vertex(10f, 10f, 10f);
            camera.Target = new Vertex(1f, 1f, 1f);
            camera.UpVector = new Vertex(0.000f, 0.000f, 1.000f);

            InitElements(scene);

            axisArcBallEffect.ArcBall.SetTranslate(
                12.490292456095853f, -1.5011389593859834f, 11.489356270615454f);
            axisArcBallEffect.ArcBall.Scale = 0.001f;


        }
        private void sceneControl_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {

            OpenGL gl = sceneControl.OpenGL;
            // 绘制模型
            DrawModel(gl);


        }
        private void DrawModel(OpenGL gl)
        {
            if (scene == null)
                return;
           /* // 应用模型的缩放变换
            gl.Scale(objectArcBallEffect.ArcBall.Scale, objectArcBallEffect.ArcBall.Scale, objectArcBallEffect.ArcBall.Scale);
           */
           
            // 遍历每个网格并绘制
            foreach (var mesh in scene.Meshes)
            {
                gl.Begin(OpenGL.GL_TRIANGLES);
                foreach (var face in mesh.Faces)
                {
                    foreach (var index in face.Indices)
                    {
                        var vertex = mesh.Vertices[index];
                        gl.Vertex(vertex.X, vertex.Y, vertex.Z);
                    }
                }
                gl.End();
            }
        }
      

        private LookAtCamera GetCamera()
        {
            return sceneControl.Scene.CurrentCamera as LookAtCamera;

        }
        private void FormMain_Resize(object sender, EventArgs e)
        {
            this.objectArcBallEffect.ArcBall.SetBounds(sceneControl.Width, sceneControl.Height);
            var gl = sceneControl.OpenGL;
            var axis = gl.UnProject(50, 50, 0.1);

            axisArcBallEffect.ArcBall.SetTranslate(axis[0], axis[1], axis[2]);
            axisArcBallEffect.ArcBall.Scale = 0.001f;

        }






    }
}
