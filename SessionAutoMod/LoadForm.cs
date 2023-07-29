using SessionAutoMod.DTO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SessionAutoMod
{
    /// <summary>
    /// Starting form
    /// </summary>
    public partial class LoadForm : Form
    {

        List<TextBox> directorys = new List<TextBox>();
        public LoadForm()
        {
            InitializeComponent();

            directorys.Add(unrealEngineFolderTextBox);
            directorys.Add(sessionGameFolderTextBox);
            directorys.Add(ueViewerTextBox);
            directorys.Add(workingFolderTextBox);
            directorys.Add(aesTextBox);
            LoadSettings();
            ShowHideSettings();
            aesTextBox.Text = "0x2d0e2b103cf0b3cb5ea8d6b774ea49400d36bd431f4bdeff74f99261bd1dabdc";
        }

        private bool SettingsCheckBool()
        {
            directorys.ForEach(directory =>
            {
                if (directory.Text.Length == 0)
                {
                    throw new Exception("kekw");
                }
            });
            return true;
        }

        private void SettingsCheck()
        {
            directorys.ForEach(directory =>
            {
                if (directory.Text.Length == 0)
                {
                    const string message = "you need to fill all felds";
                    const string caption = "Save Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception(message);
                }
            });
        }
        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsCheck();
            }
            catch (Exception)
            {
                return;
            }
            SaveSettings();
        }

        private void sessionGameFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sessionGameFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        private void unrealEngineFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                unrealEngineFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        private void ueViewerButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ueViewerTextBox.Text = dialog.SelectedPath;
            }
        }
        private void workingFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                workingFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        private void LoadSettings()
        {
            sessionGameFolderTextBox.Text = userSettings.Default.sessionGameFolder;
            unrealEngineFolderTextBox.Text = userSettings.Default.unrealEngineFolder;
            ueViewerTextBox.Text = userSettings.Default.ueViewer;
            workingFolderTextBox.Text = userSettings.Default.workingFolder;
            aesTextBox.Text = userSettings.Default.aesKey;

        }

        private void SaveSettings()
        {
            userSettings.Default.sessionGameFolder = sessionGameFolderTextBox.Text;
            userSettings.Default.unrealEngineFolder = unrealEngineFolderTextBox.Text;
            userSettings.Default.ueViewer = ueViewerTextBox.Text;
            userSettings.Default.workingFolder = workingFolderTextBox.Text;
            userSettings.Default.aesKey = aesTextBox.Text;
            userSettings.Default.Save();
        }

        private void ResetSettings()
        {
            userSettings.Default.sessionGameFolder = "";
            userSettings.Default.unrealEngineFolder = "";
            userSettings.Default.ueViewer = "";
            userSettings.Default.workingFolder = "";
            userSettings.Default.aesKey = "";
            userSettings.Default.Save();
            ueViewerTextBox.Text = userSettings.Default.ueViewer;
            sessionGameFolderTextBox.Text = userSettings.Default.sessionGameFolder;
            unrealEngineFolderTextBox.Text = userSettings.Default.unrealEngineFolder;
            workingFolderTextBox.Text = userSettings.Default.workingFolder;
            aesTextBox.Text = userSettings.Default.aesKey;
        }

        private void resetSettingsButton_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private static void ThreadProc()
        {
            SessionAutoModForm f;
            Application.Run(new SessionAutoModForm());
        }

        private void LoadMainForm()
        {
            try
            {
                SettingsCheck();
                SaveSettings();
            }
            catch (Exception)
            {
                return;
            }
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            LoadMainForm();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ShowHideSettings()
        {

            try
            {
                SettingsCheckBool();
                showHideButton.Text = "Show";
                settingsTableLayoutPanel.Visible = false;
                logoPictureBox.Visible = true;
                logoPictureBox.Enabled = true;

            }
            catch (Exception)
            {
                showHideButton.Text = "Hide";
                settingsTableLayoutPanel.Visible = true;
                logoPictureBox.Visible = false;
                logoPictureBox.Enabled = false;
                
            }
        }

        private void showHideButton_Click(object sender, EventArgs e)
        {
            if (showHideButton.Text == "Hide")
            {
                showHideButton.Text = "Show";
                settingsTableLayoutPanel.Visible = false;
                logoPictureBox.Visible = true;
                logoPictureBox.Enabled = true;
            }
            else
            {

                showHideButton.Text = "Hide";
                settingsTableLayoutPanel.Visible = true;
                logoPictureBox.Visible = false;
                logoPictureBox.Enabled = false;

            }
        }

        private void exportAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsCheck();
            }
            catch (Exception)
            {
                return;
            }
            var proc1 = new ProcessStartInfo();
            string anyCommand;
            anyCommand = "cd " + Config.ueViewerFolder + " && .\\umodel_64.exe -path=\"" + Config.sessionGameFolder + "\" -aes=" + Config.aesKey + " -game=\"ue4.27\"";
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            var url = "https://bmc.link/zenndev1337";
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}