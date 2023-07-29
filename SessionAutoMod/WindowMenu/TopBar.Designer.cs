namespace SessionAutoMod.WindowMenu
{
    partial class TopBar
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            titleLable = new Label();
            closeButton = new Button();
            minimizeButton = new Button();
            SuspendLayout();
            // 
            // titleLable
            // 
            titleLable.BackColor = Color.Transparent;
            titleLable.Dock = DockStyle.Left;
            titleLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLable.ForeColor = Color.White;
            titleLable.Location = new Point(0, 0);
            titleLable.Name = "titleLable";
            titleLable.Size = new Size(254, 26);
            titleLable.TabIndex = 0;
            titleLable.Text = "W.i.A SessionAutoMod By ZennDev";
            titleLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackgroundImage = Properties.Resources.icons8_stornieren_96;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ImageAlign = ContentAlignment.TopLeft;
            closeButton.Location = new Point(474, 1);
            closeButton.Margin = new Padding(10, 3, 10, 3);
            closeButton.Name = "closeButton";
            closeButton.Padding = new Padding(0, 10, 0, 10);
            closeButton.Size = new Size(24, 24);
            closeButton.TabIndex = 1;
            closeButton.TabStop = false;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.BackColor = Color.Black;
            minimizeButton.BackgroundImage = Properties.Resources.icons8_macos_minimieren_90;
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = SystemColors.ControlText;
            minimizeButton.Location = new Point(448, 1);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(24, 24);
            minimizeButton.TabIndex = 2;
            minimizeButton.TabStop = false;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += button1_Click;
            // 
            // TopBar
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(minimizeButton);
            Controls.Add(closeButton);
            Controls.Add(titleLable);
            Name = "TopBar";
            Size = new Size(500, 26);
            ResumeLayout(false);
        }

        #endregion

        private Label titleLable;
        private Button closeButton;
        private Button minimizeButton;
    }
}
