using SessionAutoMod.WindowMenu;
namespace SessionAutoMod
{
    partial class SessionAutoModForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionAutoModForm));
            selectBoardsButton = new Button();
            topBar2 = new TopBar();
            cookUnrealButton = new Button();
            saveModButton = new Button();
            importButton = new Button();
            SuspendLayout();
            // 
            // selectBoardsButton
            // 
            selectBoardsButton.FlatStyle = FlatStyle.Flat;
            selectBoardsButton.ForeColor = Color.White;
            selectBoardsButton.Location = new Point(81, 51);
            selectBoardsButton.Name = "selectBoardsButton";
            selectBoardsButton.Size = new Size(180, 35);
            selectBoardsButton.TabIndex = 2;
            selectBoardsButton.TabStop = false;
            selectBoardsButton.Text = "Select the boards to mod";
            selectBoardsButton.UseVisualStyleBackColor = true;
            selectBoardsButton.Click += selectBoardsButton_Click;
            // 
            // topBar2
            // 
            topBar2.AllowDrop = true;
            topBar2.BackColor = Color.Black;
            topBar2.Dock = DockStyle.Top;
            topBar2.Location = new Point(0, 0);
            topBar2.Name = "topBar2";
            topBar2.Size = new Size(340, 26);
            topBar2.TabIndex = 4;
            topBar2.MouseDown += topBar2_MouseDown;
            // 
            // cookUnrealButton
            // 
            cookUnrealButton.FlatStyle = FlatStyle.Flat;
            cookUnrealButton.ForeColor = Color.White;
            cookUnrealButton.Location = new Point(176, 92);
            cookUnrealButton.Name = "cookUnrealButton";
            cookUnrealButton.Size = new Size(85, 35);
            cookUnrealButton.TabIndex = 2;
            cookUnrealButton.TabStop = false;
            cookUnrealButton.Text = "Cook";
            cookUnrealButton.UseVisualStyleBackColor = true;
            cookUnrealButton.Click += cookUnrealButton_Click;
            // 
            // saveModButton
            // 
            saveModButton.FlatStyle = FlatStyle.Flat;
            saveModButton.ForeColor = Color.White;
            saveModButton.Location = new Point(81, 133);
            saveModButton.Name = "saveModButton";
            saveModButton.Size = new Size(180, 35);
            saveModButton.TabIndex = 2;
            saveModButton.TabStop = false;
            saveModButton.Text = "Make it ready to skate";
            saveModButton.UseVisualStyleBackColor = true;
            saveModButton.Click += saveModButton_Click;
            // 
            // importButton
            // 
            importButton.FlatStyle = FlatStyle.Flat;
            importButton.ForeColor = Color.White;
            importButton.Location = new Point(81, 92);
            importButton.Name = "importButton";
            importButton.Size = new Size(85, 35);
            importButton.TabIndex = 2;
            importButton.TabStop = false;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // SessionAutoModForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(340, 200);
            Controls.Add(topBar2);
            Controls.Add(saveModButton);
            Controls.Add(importButton);
            Controls.Add(cookUnrealButton);
            Controls.Add(selectBoardsButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SessionAutoModForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "W.i.A Session Auto Mod by ZennDev";
            ResumeLayout(false);
        }

        #endregion
        private Button selectBoardsButton;
        private TopBar topBar2;
        private Button cookUnrealButton;
        private Button saveModButton;
        private Button importButton;
    }
}