using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Assimp;
using SharpGL;
using SharpGL.SceneGraph;
using AssimpScene = Assimp.Scene;


namespace Qizhi
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool m_bSaveLayout = true;
        private DrawWindow m_drawWindow;
        private AssimpContext assimpContext;
        private AssimpScene scene;
        public Form()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;

            dockPanel1.MouseMove += DockPanel_MouseMove;
          
            CreateStandardControls();
            assimpContext = new AssimpContext();
            m_drawWindow = new DrawWindow();
           
            /*sceneControl = new SharpGL.SceneControl();
            m_drawWindow.SetSceneControl(sceneControl);*/
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            
        }
        private void CreateStandardControls()
        {
            m_drawWindow = new DrawWindow();
        }
        private void 绘图HToolStripButton_Click(object sender, EventArgs e)
        {
            m_drawWindow.Show(dockPanel1);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            About aboutDialog = new About();
            aboutDialog.ShowDialog(this);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_drawWindow.Show(dockPanel1);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            m_drawWindow.Show(dockPanel1);
        }
        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter =
                "OBJ Files (*.obj)|*.obj|" +
                "rtf files (*.rtf)|*.rtf|" +
                "txt files (*.txt)|*.txt|" +
                "Revit project files(*.rvt)| *.rvt |" +
                "Revit family files(*.rfa)|*.rfa |" +
                "Revit family template files(*.rft) | *.rft |" +
                "All files(=.=) | *.* ";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fullName = openFile.FileName;
                string fileName = Path.GetFileName(fullName);

                if (FindDocument(fileName) != null)
                {
                    MessageBox.Show("The document: " + fileName + " has already opened!");
                    return;
                }

                

            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter =
                "OBJ Files (*.obj)|*.obj|" +
                "txt files (*.txt)|*.txt|" +             
                "All files(=.=) | *.* ";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                

                string path = openFile.FileName;
               
               

                // 刷新绘制
                m_drawWindow.LoadModel(path);
            }
        }
        private IDockContent FindDocument(string text)
        {
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel1.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
        }

        private void 打印PToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }
        private void SaveAstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // 设置保存文件的筛选器
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 可以添加更多的筛选器，以支持不同类型的文件格式，格式为："描述1|扩展名1|描述2|扩展名2|..."

            // 设置默认的文件名
            saveFileDialog.FileName = "filenameVer2024.txt";

            // 显示对话框，并检查用户是否点击了保存按钮
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件名
                string filePath = saveFileDialog.FileName;
                try
                {
                   
                    // 执行保存文件的逻辑
                    // 这里只是一个示例，实际保存文件的逻辑需要根据你的需求来实现
                    File.WriteAllText(filePath,"保存内容");

                    MessageBox.Show("文件保存成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存文件时出现错误：{ex.Message}");
                }
                // 执行保存文件的逻辑，例如保存文件到指定路径
                // 这里只是一个示例，实际保存文件的逻辑需要根据你的需求来实现
                // File.WriteAllText(filePath, "Content of the file");
            }
            
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveAs saveAs = new SaveAs();
            saveAs.ShowDialog();
        }
        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/qizhoward/3DGL";

            try
            {
                // 使用默认浏览器打开URL
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // 如果出现错误，显示错误消息
                MessageBox.Show("无法打开浏览器: " + ex.Message);
            }
        }


        #region 鼠标位置
        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point dockPanelMousePos = e.Location;
            toolStripStatusLabel4.Text = dockPanelMousePos.X + "," + dockPanelMousePos.Y;
        }

     
        #endregion

        #region 版本更新
        private async void updataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "检查更新中...";
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            try
            {
                string latestVersion = await Task.Run(() => GetLatestReleaseVersionAsync("qizhoward", "3DGL"));
                string localVersion = GetLocalVersion();

                if (!string.IsNullOrEmpty(latestVersion))
                {
                    toolStripStatusLabel1.Text = $"最新版本: {latestVersion}";
                    if (IsNewerVersion(localVersion, latestVersion))
                    {
                        toolStripStatusLabel1.Text = $"发现新版本: {latestVersion}，正在下载...";
                        await DownloadLatestReleaseAsync("qizhoward", "3DGL", latestVersion);
                        toolStripStatusLabel1.Text = "下载完成，请安装新版本。";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "当前已是最新版本。";
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "检查更新失败";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"检查更新失败: {ex.Message}";
            }

            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;

        }
        private async Task<string> GetLatestReleaseVersionAsync(string owner, string repo)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("request"); // GitHub API 需要用户代理

                string url = $"https://api.github.com/repos/qizhoward/3DGL/releases/latest";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                return json["tag_name"]?.ToString();
            }
        }
        private string GetLocalVersion()
        {
            // 获取当前执行的程序集
            var assembly = Assembly.GetExecutingAssembly();

            // 获取程序集版本信息
            var version = assembly.GetName().Version;

            return version.ToString();
        }
        private bool IsNewerVersion(string localVersion, string latestVersion)
        {
            Version local = new Version(localVersion);
            Version latest = new Version(latestVersion);

            return latest.CompareTo(local) > 0;
        }
        private async Task DownloadLatestReleaseAsync(string owner, string repo, string version)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("request"); // GitHub API 需要用户代理

                string url = $"https://api.github.com/repos/qizhoward/3DGL/releases/tags/{version}";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                string downloadUrl = json["assets"]?[0]?["browser_download_url"]?.ToString();
                if (downloadUrl != null)
                {
                    HttpResponseMessage downloadResponse = await client.GetAsync(downloadUrl);
                    downloadResponse.EnsureSuccessStatusCode();

                    byte[] fileBytes = await downloadResponse.Content.ReadAsByteArrayAsync();

                    // 保存文件
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Qizhi_latest_release.exe");
                    await Task.Run(() => File.WriteAllBytes(filePath, fileBytes));
                    // 提示保存路径（可选）
                    MessageBox.Show($"新版本已下载到 {filePath}", "下载完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        
    
    }
}
