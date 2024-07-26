using SharpGL;
using SharpGL.SceneGraph.Core;
using SharpGL.SceneGraph;

namespace Qizhi.figures
{
    class Axies : SceneElement, IRenderable
    {
        private DisplayList displayList;

        public Axies()
        {
            Name = "Design Time Axies";
        }

        public void Render(OpenGL gl, RenderMode renderMode)
        {
            //  设计时原语只在设计模式中呈现
            if (renderMode != RenderMode.Design)
                return;
            //  如果我们没有显示列表，我们必须创建它
            //  否则，我们可以简单地调用显示列表
            //  If we do not have the display list, we must create it.
            //  Otherwise, we can simple call the display list.
            if (displayList == null)
                CreateDisplayList(gl);
            else
                displayList.Call(gl);

        }

        private void CreateDisplayList(OpenGL gl)
        {
            //  创建显示列表 
            displayList = new DisplayList();
            //  生成显示列表
            displayList.Generate(gl);
            displayList.New(gl, DisplayList.DisplayListMode.CompileAndExecute);
          
            //  推动所有属性，禁用照明和深度测试
            gl.PushAttrib(OpenGL.GL_CURRENT_BIT | OpenGL.GL_ENABLE_BIT |
                OpenGL.GL_LINE_BIT | OpenGL.GL_DEPTH_BUFFER_BIT | OpenGL.GL_POSITION );
            gl.Disable(OpenGL.GL_LIGHTING);
            gl.Disable(OpenGL.GL_TEXTURE_2D);
            gl.DepthFunc(OpenGL.GL_ALWAYS);
            //  设置一条漂亮的线宽
            //  Set a nice fat line width.
            gl.LineWidth(1.5f);
            //  画出
            //  Draw the axies.
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(1f, 0f, 0f, 1f);
            gl.Vertex(0, 0, 0);
            gl.Vertex(2, 0, 0);
            gl.Color(0f, 1f, 0f, 1f);
            gl.Vertex(0, 0, 0);
            gl.Vertex(0, 2, 0);
            gl.Color(0f, 0f, 1f, 1f);
            gl.Vertex(0, 0, 0);
            gl.Vertex(0, 0, 2);
            gl.Translate(0.0f, 0.0f, 0.0f);
            gl.End();
            //  恢复属性
            //  Restore attributes.
            gl.PopAttrib();

            gl.Begin(OpenGL.GL_TRIANGLES);					// Start Drawing The Pyramid
          
            #region 画出金字塔
          /*gl.Vertex(0.0f, 1.0f, 0.0f);			// Top Of Triangle (Front)  //back
            gl.Vertex(0.0f, 0.0f, 0.0f);			// Left Of Triangle (Front) //back
            gl.Vertex(0.5f, 0.5f, 1.0f);			// Right Of Triangle (Front)//back

            gl.Vertex(1.0f, 0.0f, 0.0f);			// Top Of Triangle (Right)
            gl.Vertex(0.0f, 0.0f, 0.0f);			// Left Of Triangle (Right)
            gl.Vertex(0.5f, 0.5f, 1.0f);            // Right Of Triangle (Right)

            gl.Vertex(1.0f, 1.0f, 0.0f);			// Top Of Triangle (Back)
            gl.Vertex(1.0f, 0.0f, 0.0f);			// Left Of Triangle (Back)
            gl.Vertex(0.5f, 0.5f, 1.0f);            // Right Of Triangle (Back)

            gl.Vertex(0.0f, 1.0f, 0.0f);			// Top Of Triangle (Left)
            gl.Vertex(1.0f, 1.0f, 0.0f);			// Left Of Triangle (Left)
            gl.Vertex(0.5f, 0.5f, 1.0f);            // Right Of Triangle (Left)
            */
            #endregion

            gl.Vertex(0.0f, 2.0f, 0.0f);			
            gl.Vertex(2.0f, 0.0f, 2.0f);			
            gl.Vertex(0.0f, 2.0f, 0.0f);
            gl.Vertex(0.0f, -2.0f, 0.0f);
            
            gl.Color(1.0f, 1.0f, 0.0f);


            gl.Translate(2.0f, 2.0f, 0.0f);

            gl.End();                       // Done Drawing The Pyramid



           



            //  结束显示列表
            //  End the display list.
            displayList.End(gl);
        }

        



    }
}
