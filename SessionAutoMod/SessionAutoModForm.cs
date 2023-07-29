using SessionAutoMod.Boards;
using SessionAutoMod.DTO;
using System.Diagnostics;
using System.IO.Compression;

namespace SessionAutoMod
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class SessionAutoModForm : Form
    {
        private List<BoardFile> selectedBoards = new List<BoardFile>();
        public SessionAutoModForm()
        {
            InitializeComponent();

        }

        private void SaveSelectetToWorkDir()
        {
            if (selectedBoards.Count < 1)
            {
                MessageBox.Show("Choose at least one board", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Directory.Exists(Config.workingFolder + @"\Game"))
                Directory.Delete(Config.workingFolder + @"\Game", true);
            foreach (var item in selectedBoards)
            {
                try
                {
                    if (!Directory.Exists(Config.workingFolder
                        + @"\Game\Customization\Skateboards\DeckGraphics\"
                        + item.BoardBrand.Name))
                        Directory.CreateDirectory(Config.workingFolder
                            + @"\Game\Customization\Skateboards\DeckGraphics\"
                            + item.BoardBrand.Name);
                    File.Copy(item.Path, Config.workingFolder
                        + @"\Game\Customization\Skateboards\DeckGraphics\"
                        + item.BoardBrand.Name
                        + @"\"
                        + item.Name, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }
            }
            MessageBox.Show("You can now edit the Boards in your working directory", "Edit now", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selectBoardsButton_Click(object sender, EventArgs e)
        {
            var sb = selectedBoards;
            Boards.Boards boards = new Boards.Boards(sb);
            var result = boards.ShowDialog();
            if (result == DialogResult.OK)
                selectedBoards = boards.BoardFilesReturn;
            if (result == DialogResult.Cancel)
            {
                selectedBoards.Clear();
            }

            SaveSelectetToWorkDir();

        }

        private void ImportToUnreal()
        {
            if (Directory.Exists(Config.workingFolder + @"\Boards"))
                Directory.Delete(Config.workingFolder + @"\Boards", true);
            ZipFile.ExtractToDirectory(Config.workingFolder + @"\DoNotTouchThis.zip", Config.workingFolder);
            if (Directory.Exists(Config.workingFolder + @"\Boards\Content\Game"))
                Directory.Delete(Config.workingFolder + @"\Boards\Content\Game", true);
            Directory.Move(Config.workingFolder + @"\Game", Config.workingFolder + @"\Boards\Content\Game");
            System.Threading.Thread.Sleep(5000);
            var proc1 = new ProcessStartInfo();
            string anyCommand;
            anyCommand = "cd " + Config.unrealEngineFolder + " && .\\UE4Editor.exe \"" + Config.workingFolder + "\\Boards\\Boards.uproject\"";
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void CookInUnreal()
        {

            var proc1 = new ProcessStartInfo();
            string anyCommand;
            anyCommand = "cd " + Config.unrealEngineFolder + " && .\\UE4Editor.exe \"" + Config.workingFolder + "\\Boards\\Boards.uproject\"  -run=cook -targetplatform=WindowsNoEditor ";
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Config.workingFolder + @"\Game"))
                return;
            ImportToUnreal();
        }

        private void cookUnrealButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Config.workingFolder + @"\Boards\Content\Game"))
                return;
            //System.Threading.Thread.Sleep(12000);

            foreach (var process in Process.GetProcessesByName("UE4Editor"))
            {
                process.Kill();
            }
            CookInUnreal();
        }

        private void saveModButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Config.workingFolder + @"\Boards\Saved\Cooked\WindowsNoEditor\Boards\Content\Game"))
                return;
            if (!Directory.Exists(Config.workingFolder + @"\Cooked"))
                Directory.CreateDirectory(Config.workingFolder + @"\Cooked");
            if (Directory.Exists(Config.workingFolder + @"\Cooked\Game"))
                Directory.Delete(Config.workingFolder + @"\Cooked\Game", true);
            Directory.Move(Config.workingFolder + @"\Boards\Saved\Cooked\WindowsNoEditor\Boards\Content\Game", Config.workingFolder + @"\Cooked\Game");

            string saveDir = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Zip Files (*.zip)|*.zip";
            dialog.DefaultExt = "zip";
            dialog.InitialDirectory = Config.workingFolder;
            //dlg.AddExtension = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveDir = dialog.FileName;
            }
            Debug.WriteLine(saveDir);
            if (File.Exists(saveDir))
                File.Delete(saveDir);
            ZipFile.CreateFromDirectory(Config.workingFolder + @"\Cooked", saveDir);
            if (Directory.Exists(Config.workingFolder + @"\Cooked"))
                Directory.Delete(Config.workingFolder + @"\Cooked", true);
            if (Directory.Exists(Config.workingFolder + @"\Boards"))
                Directory.Delete(Config.workingFolder + @"\Boards", true);
            if (Directory.Exists(Config.workingFolder + @"\Game"))
                Directory.Delete(Config.workingFolder + @"\Game", true);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void topBar2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


    }
}
