using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Reflection;

namespace Qizhi
{
    public partial class About : System.Windows.Forms.Form
    {
        public About()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void About_Load(object sender, EventArgs e)
        {
            labelAppVersion.Text = typeof(Form).Assembly.GetName().Version.ToString();
            labelLibVersion.Text = typeof(DockPanel).Assembly.GetName().Version.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelLibVersion_Click(object sender, EventArgs e)
        {

        }

        private void labelAppVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
