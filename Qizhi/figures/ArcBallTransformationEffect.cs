using SharpGL.SceneGraph.Core;
using System.ComponentModel;
using SharpGL.SceneGraph.Effects;
using SharpGL;

namespace Qizhi.figures
{
    class ArcBallEffect : Effect
    {
        public ArcBallEffect(float eyex, float eyey, float eyez,
            float centerx, float centery, float centerz,
            float upx, float upy, float upz)
        {
            this.arcBall = new ArcBall(eyex, eyey, eyez, centerx, centery, centerz, upx, upy, upz);
        }


        public override void Push(OpenGL gl, SceneElement parentElement)
        {
            gl.PushMatrix();

            //  Perform the transformation.
            arcBall.TransformMatrix(gl);
        }

        public override void Pop(OpenGL gl, SceneElement parentElement)
        {
            gl.PopMatrix();
        }


        private ArcBall arcBall;// = new ArcBall();
        public ArcBall ArcBall
        {
            get { return arcBall; }
            set { arcBall = value; }
        }

    }
}