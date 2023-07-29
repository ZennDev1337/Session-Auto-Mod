namespace SessionAutoMod
{
    partial class LoadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            sessionGameFolderButton = new Button();
            sessionGameFolderTextBox = new TextBox();
            sessionGameFolderLabel = new Label();
            unrealEngineFolderButton = new Button();
            unrealEngineFolderTextBox = new TextBox();
            unrealEngineFolderLable = new Label();
            saveSettingsButton = new Button();
            resetSettingsButton = new Button();
            nextButton = new Button();
            ueViewerButton = new Button();
            ueViewerTextBox = new TextBox();
            ueViewerLable = new Label();
            workingFolderButton = new Button();
            workingFolderTextBox = new TextBox();
            workingFolderLable = new Label();
            aesTextBox = new TextBox();
            aesLable = new Label();
            topBar1 = new WindowMenu.TopBar();
            showHideButton = new Button();
            settingsTableLayoutPanel = new TableLayoutPanel();
            exportAllButton = new Button();
            logoPictureBox = new PictureBox();
            linkLabel1 = new LinkLabel();
            settingsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sessionGameFolderButton
            // 
            sessionGameFolderButton.Dock = DockStyle.Fill;
            sessionGameFolderButton.FlatStyle = FlatStyle.Flat;
            sessionGameFolderButton.ForeColor = Color.White;
            sessionGameFolderButton.Location = new Point(619, 3);
            sessionGameFolderButton.Name = "sessionGameFolderButton";
            sessionGameFolderButton.Size = new Size(27, 23);
            sessionGameFolderButton.TabIndex = 0;
            sessionGameFolderButton.TabStop = false;
            sessionGameFolderButton.Text = "...";
            sessionGameFolderButton.UseVisualStyleBackColor = true;
            sessionGameFolderButton.Click += sessionGameFolderButton_Click;
            // 
            // sessionGameFolderTextBox
            // 
            sessionGameFolderTextBox.BackColor = Color.FromArgb(64, 64, 64);
            sessionGameFolderTextBox.BorderStyle = BorderStyle.None;
            sessionGameFolderTextBox.Dock = DockStyle.Fill;
            sessionGameFolderTextBox.ForeColor = Color.White;
            sessionGameFolderTextBox.Location = new Point(165, 3);
            sessionGameFolderTextBox.Name = "sessionGameFolderTextBox";
            sessionGameFolderTextBox.ReadOnly = true;
            sessionGameFolderTextBox.Size = new Size(448, 16);
            sessionGameFolderTextBox.TabIndex = 1;
            sessionGameFolderTextBox.TabStop = false;
            // 
            // sessionGameFolderLabel
            // 
            sessionGameFolderLabel.AutoSize = true;
            sessionGameFolderLabel.Dock = DockStyle.Fill;
            sessionGameFolderLabel.ForeColor = Color.White;
            sessionGameFolderLabel.Location = new Point(3, 0);
            sessionGameFolderLabel.Name = "sessionGameFolderLabel";
            sessionGameFolderLabel.Size = new Size(156, 29);
            sessionGameFolderLabel.TabIndex = 2;
            sessionGameFolderLabel.Text = "Select Session gamefolder";
            // 
            // unrealEngineFolderButton
            // 
            unrealEngineFolderButton.Dock = DockStyle.Fill;
            unrealEngineFolderButton.FlatStyle = FlatStyle.Flat;
            unrealEngineFolderButton.ForeColor = Color.White;
            unrealEngineFolderButton.Location = new Point(619, 32);
            unrealEngineFolderButton.Name = "unrealEngineFolderButton";
            unrealEngineFolderButton.Size = new Size(27, 23);
            unrealEngineFolderButton.TabIndex = 0;
            unrealEngineFolderButton.TabStop = false;
            unrealEngineFolderButton.Text = "...";
            unrealEngineFolderButton.UseVisualStyleBackColor = true;
            unrealEngineFolderButton.Click += unrealEngineFolderButton_Click;
            // 
            // unrealEngineFolderTextBox
            // 
            unrealEngineFolderTextBox.BackColor = Color.FromArgb(64, 64, 64);
            unrealEngineFolderTextBox.BorderStyle = BorderStyle.None;
            unrealEngineFolderTextBox.Dock = DockStyle.Fill;
            unrealEngineFolderTextBox.ForeColor = Color.White;
            unrealEngineFolderTextBox.Location = new Point(165, 32);
            unrealEngineFolderTextBox.Name = "unrealEngineFolderTextBox";
            unrealEngineFolderTextBox.ReadOnly = true;
            unrealEngineFolderTextBox.Size = new Size(448, 16);
            unrealEngineFolderTextBox.TabIndex = 1;
            unrealEngineFolderTextBox.TabStop = false;
            // 
            // unrealEngineFolderLable
            // 
            unrealEngineFolderLable.AutoSize = true;
            unrealEngineFolderLable.Dock = DockStyle.Fill;
            unrealEngineFolderLable.ForeColor = Color.White;
            unrealEngineFolderLable.Location = new Point(3, 29);
            unrealEngineFolderLable.Name = "unrealEngineFolderLable";
            unrealEngineFolderLable.Size = new Size(156, 29);
            unrealEngineFolderLable.TabIndex = 2;
            unrealEngineFolderLable.Text = "Unreal-Engine folder";
            // 
            // saveSettingsButton
            // 
            saveSettingsButton.Anchor = AnchorStyles.Top;
            saveSettingsButton.FlatStyle = FlatStyle.Flat;
            saveSettingsButton.ForeColor = Color.White;
            saveSettingsButton.Location = new Point(118, 228);
            saveSettingsButton.Name = "saveSettingsButton";
            saveSettingsButton.Size = new Size(100, 35);
            saveSettingsButton.TabIndex = 3;
            saveSettingsButton.TabStop = false;
            saveSettingsButton.Text = "Save settings";
            saveSettingsButton.UseVisualStyleBackColor = true;
            saveSettingsButton.Click += saveSettingsButton_Click;
            // 
            // resetSettingsButton
            // 
            resetSettingsButton.Anchor = AnchorStyles.Top;
            resetSettingsButton.FlatStyle = FlatStyle.Flat;
            resetSettingsButton.ForeColor = Color.White;
            resetSettingsButton.Location = new Point(12, 228);
            resetSettingsButton.Name = "resetSettingsButton";
            resetSettingsButton.Size = new Size(100, 35);
            resetSettingsButton.TabIndex = 3;
            resetSettingsButton.TabStop = false;
            resetSettingsButton.Text = "Reset settings";
            resetSettingsButton.UseVisualStyleBackColor = true;
            resetSettingsButton.Click += resetSettingsButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Top;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(558, 228);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(100, 35);
            nextButton.TabIndex = 4;
            nextButton.TabStop = false;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // ueViewerButton
            // 
            ueViewerButton.Dock = DockStyle.Fill;
            ueViewerButton.FlatStyle = FlatStyle.Flat;
            ueViewerButton.ForeColor = Color.White;
            ueViewerButton.Location = new Point(619, 61);
            ueViewerButton.Name = "ueViewerButton";
            ueViewerButton.Size = new Size(27, 23);
            ueViewerButton.TabIndex = 0;
            ueViewerButton.TabStop = false;
            ueViewerButton.Text = "...";
            ueViewerButton.UseVisualStyleBackColor = true;
            ueViewerButton.Click += ueViewerButton_Click;
            // 
            // ueViewerTextBox
            // 
            ueViewerTextBox.BackColor = Color.FromArgb(64, 64, 64);
            ueViewerTextBox.BorderStyle = BorderStyle.None;
            ueViewerTextBox.Dock = DockStyle.Fill;
            ueViewerTextBox.ForeColor = Color.White;
            ueViewerTextBox.Location = new Point(165, 61);
            ueViewerTextBox.Name = "ueViewerTextBox";
            ueViewerTextBox.ReadOnly = true;
            ueViewerTextBox.Size = new Size(448, 16);
            ueViewerTextBox.TabIndex = 1;
            ueViewerTextBox.TabStop = false;
            // 
            // ueViewerLable
            // 
            ueViewerLable.AutoSize = true;
            ueViewerLable.Dock = DockStyle.Fill;
            ueViewerLable.ForeColor = Color.White;
            ueViewerLable.Location = new Point(3, 58);
            ueViewerLable.Name = "ueViewerLable";
            ueViewerLable.Size = new Size(156, 29);
            ueViewerLable.TabIndex = 2;
            ueViewerLable.Text = "UE Viewer folder";
            // 
            // workingFolderButton
            // 
            workingFolderButton.Dock = DockStyle.Fill;
            workingFolderButton.FlatStyle = FlatStyle.Flat;
            workingFolderButton.ForeColor = Color.White;
            workingFolderButton.Location = new Point(619, 90);
            workingFolderButton.Name = "workingFolderButton";
            workingFolderButton.Size = new Size(27, 23);
            workingFolderButton.TabIndex = 0;
            workingFolderButton.TabStop = false;
            workingFolderButton.Text = "...";
            workingFolderButton.UseVisualStyleBackColor = true;
            workingFolderButton.Click += workingFolderButton_Click;
            // 
            // workingFolderTextBox
            // 
            workingFolderTextBox.BackColor = Color.FromArgb(64, 64, 64);
            workingFolderTextBox.BorderStyle = BorderStyle.None;
            workingFolderTextBox.Dock = DockStyle.Fill;
            workingFolderTextBox.ForeColor = Color.White;
            workingFolderTextBox.Location = new Point(165, 90);
            workingFolderTextBox.Name = "workingFolderTextBox";
            workingFolderTextBox.ReadOnly = true;
            workingFolderTextBox.Size = new Size(448, 16);
            workingFolderTextBox.TabIndex = 1;
            workingFolderTextBox.TabStop = false;
            // 
            // workingFolderLable
            // 
            workingFolderLable.AutoSize = true;
            workingFolderLable.Dock = DockStyle.Fill;
            workingFolderLable.ForeColor = Color.White;
            workingFolderLable.Location = new Point(3, 87);
            workingFolderLable.Name = "workingFolderLable";
            workingFolderLable.Size = new Size(156, 29);
            workingFolderLable.TabIndex = 2;
            workingFolderLable.Text = "Working folder";
            // 
            // aesTextBox
            // 
            aesTextBox.BackColor = Color.DimGray;
            aesTextBox.BorderStyle = BorderStyle.None;
            aesTextBox.Cursor = Cursors.IBeam;
            aesTextBox.Dock = DockStyle.Fill;
            aesTextBox.ForeColor = Color.White;
            aesTextBox.Location = new Point(165, 119);
            aesTextBox.Name = "aesTextBox";
            aesTextBox.Size = new Size(448, 16);
            aesTextBox.TabIndex = 1;
            // 
            // aesLable
            // 
            aesLable.AutoSize = true;
            aesLable.Dock = DockStyle.Fill;
            aesLable.ForeColor = Color.White;
            aesLable.Location = new Point(3, 116);
            aesLable.Name = "aesLable";
            aesLable.Size = new Size(156, 33);
            aesLable.TabIndex = 2;
            aesLable.Text = "AES-Key";
            // 
            // topBar1
            // 
            topBar1.AllowDrop = true;
            topBar1.BackColor = Color.Black;
            topBar1.Dock = DockStyle.Top;
            topBar1.Location = new Point(0, 0);
            topBar1.Name = "topBar1";
            topBar1.Size = new Size(670, 26);
            topBar1.TabIndex = 5;
            topBar1.MouseDown += topBar1_MouseDown;
            // 
            // showHideButton
            // 
            showHideButton.Anchor = AnchorStyles.Top;
            showHideButton.FlatStyle = FlatStyle.Flat;
            showHideButton.ForeColor = Color.White;
            showHideButton.Location = new Point(285, 187);
            showHideButton.Name = "showHideButton";
            showHideButton.Size = new Size(100, 35);
            showHideButton.TabIndex = 4;
            showHideButton.TabStop = false;
            showHideButton.Text = "Hide";
            showHideButton.UseVisualStyleBackColor = true;
            showHideButton.Click += showHideButton_Click;
            // 
            // settingsTableLayoutPanel
            // 
            settingsTableLayoutPanel.ColumnCount = 3;
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            settingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            settingsTableLayoutPanel.Controls.Add(aesLable, 0, 4);
            settingsTableLayoutPanel.Controls.Add(workingFolderLable, 0, 3);
            settingsTableLayoutPanel.Controls.Add(ueViewerLable, 0, 2);
            settingsTableLayoutPanel.Controls.Add(unrealEngineFolderLable, 0, 1);
            settingsTableLayoutPanel.Controls.Add(sessionGameFolderLabel, 0, 0);
            settingsTableLayoutPanel.Controls.Add(sessionGameFolderTextBox, 1, 0);
            settingsTableLayoutPanel.Controls.Add(workingFolderButton, 2, 3);
            settingsTableLayoutPanel.Controls.Add(ueViewerButton, 2, 2);
            settingsTableLayoutPanel.Controls.Add(ueViewerTextBox, 1, 2);
            settingsTableLayoutPanel.Controls.Add(aesTextBox, 1, 4);
            settingsTableLayoutPanel.Controls.Add(unrealEngineFolderButton, 2, 1);
            settingsTableLayoutPanel.Controls.Add(workingFolderTextBox, 1, 3);
            settingsTableLayoutPanel.Controls.Add(sessionGameFolderButton, 2, 0);
            settingsTableLayoutPanel.Controls.Add(unrealEngineFolderTextBox, 1, 1);
            settingsTableLayoutPanel.Location = new Point(12, 32);
            settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            settingsTableLayoutPanel.RowCount = 5;
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            settingsTableLayoutPanel.Size = new Size(649, 149);
            settingsTableLayoutPanel.TabIndex = 6;
            // 
            // exportAllButton
            // 
            exportAllButton.Anchor = AnchorStyles.Top;
            exportAllButton.FlatStyle = FlatStyle.Flat;
            exportAllButton.ForeColor = Color.White;
            exportAllButton.Location = new Point(275, 228);
            exportAllButton.Name = "exportAllButton";
            exportAllButton.Size = new Size(120, 35);
            exportAllButton.TabIndex = 7;
            exportAllButton.TabStop = false;
            exportAllButton.Text = "Export all models";
            exportAllButton.UseVisualStyleBackColor = true;
            exportAllButton.Click += exportAllButton_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Enabled = false;
            logoPictureBox.Image = Properties.Resources.ezgif_3_cc9ef65cbf;
            logoPictureBox.Location = new Point(494, 64);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(164, 158);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 8;
            logoPictureBox.TabStop = false;
            logoPictureBox.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(12, 187);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 30);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Buy a Coffee for\r\nZennDev1337";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(670, 274);
            Controls.Add(linkLabel1);
            Controls.Add(settingsTableLayoutPanel);
            Controls.Add(logoPictureBox);
            Controls.Add(exportAllButton);
            Controls.Add(topBar1);
            Controls.Add(showHideButton);
            Controls.Add(nextButton);
            Controls.Add(resetSettingsButton);
            Controls.Add(saveSettingsButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(641, 240);
            Name = "LoadForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "W.i.A Session Auto Mod by ZennDev";
            settingsTableLayoutPanel.ResumeLayout(false);
            settingsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button sessionGameFolderButton;
        private TextBox sessionGameFolderTextBox;
        private Label sessionGameFolderLabel;
        private Button unrealEngineFolderButton;
        private TextBox unrealEngineFolderTextBox;
        private Label unrealEngineFolderLable;
        private Button saveSettingsButton;
        private Button resetSettingsButton;
        private Button nextButton;
        private Button ueViewerButton;
        private TextBox ueViewerTextBox;
        private Label ueViewerLable;
        private Button workingFolderButton;
        private TextBox workingFolderTextBox;
        private Label workingFolderLable;
        private TextBox aesTextBox;
        private Label aesLable;
        private WindowMenu.TopBar topBar1;
        private Button showHideButton;
        private TableLayoutPanel settingsTableLayoutPanel;
        private Button exportAllButton;
        private PictureBox logoPictureBox;
        private LinkLabel linkLabel1;
    }
}