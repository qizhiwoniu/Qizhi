
using System.Windows.Forms;

namespace Qizhi
{
    partial class DrawWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sceneControl = new SharpGL.SceneControl();
            ((System.ComponentModel.ISupportInitialize)(this.sceneControl)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneControl
            // 
            this.sceneControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.sceneControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneControl.DrawFPS = false;
            this.sceneControl.Location = new System.Drawing.Point(0, 0);
            this.sceneControl.Name = "sceneControl";
            this.sceneControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.sceneControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.sceneControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.sceneControl.Size = new System.Drawing.Size(319, 500);
            this.sceneControl.TabIndex = 0;
            this.sceneControl.OpenGLInitialized += new System.EventHandler(this.sceneControl_OpenGLInitialized);
            this.sceneControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.sceneControl_OpenGLDraw);
            this.sceneControl.Load += new System.EventHandler(this.sceneControl_Load);
            this.sceneControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sceneControl_KeyDown);
            this.sceneControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sceneControl_MouseDown);
            this.sceneControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sceneControl_MouseMove);
            this.sceneControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sceneControl_MouseUp);
            // 
            // DrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 500);
            this.Controls.Add(this.sceneControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawWindow";
            this.Text = "DrawWindow";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sceneControl)).EndInit();
            this.ResumeLayout(false);
            //
            // 初始化 ContextMenuStrip
            //
            contextMenuStrip = new ContextMenuStrip();
            // 初始化菜单项
            menuItem1 = new ToolStripMenuItem();
            menuItem1.Text = "菜单项1";
            menuItem1.Click += MenuItem1_Click; // 菜单项1 的点击事件处理函数
            menuItem2 = new ToolStripMenuItem();
            menuItem2.Text = "菜单项2";
            menuItem2.Click += MenuItem2_Click; // 菜单项2 的点击事件处理函数

            // 将菜单项添加到 ContextMenuStrip 中
            contextMenuStrip.Items.Add(menuItem1);
            contextMenuStrip.Items.Add(menuItem2);

            // 在 sceneControl 上关联 ContextMenuStrip
            sceneControl.ContextMenuStrip = contextMenuStrip;
        }

        #endregion

        private SharpGL.SceneControl sceneControl;
        
    }
}