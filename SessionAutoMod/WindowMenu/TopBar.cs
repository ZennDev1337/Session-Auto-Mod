namespace SessionAutoMod.WindowMenu
{
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parentForm = (this.Parent as Form);
            parentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
