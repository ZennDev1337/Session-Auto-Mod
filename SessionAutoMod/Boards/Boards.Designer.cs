namespace SessionAutoMod.Boards
{
    partial class Boards
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
            boardMarkeComboBox = new ComboBox();
            brandChooseLable = new Label();
            boardCheckedListBox = new CheckedListBox();
            selectedTreeView = new TreeView();
            selectedBoardsLable = new Label();
            saveSelectedBoardsButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // boardMarkeComboBox
            // 
            boardMarkeComboBox.BackColor = Color.DimGray;
            boardMarkeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            boardMarkeComboBox.FlatStyle = FlatStyle.Flat;
            boardMarkeComboBox.ForeColor = Color.White;
            boardMarkeComboBox.FormattingEnabled = true;
            boardMarkeComboBox.Location = new Point(12, 42);
            boardMarkeComboBox.Name = "boardMarkeComboBox";
            boardMarkeComboBox.Size = new Size(249, 23);
            boardMarkeComboBox.TabIndex = 0;
            boardMarkeComboBox.SelectedValueChanged += boardMarkeComboBox_SelectedValueChanged;
            // 
            // brandChooseLable
            // 
            brandChooseLable.AutoSize = true;
            brandChooseLable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            brandChooseLable.ForeColor = Color.White;
            brandChooseLable.Location = new Point(12, 9);
            brandChooseLable.Name = "brandChooseLable";
            brandChooseLable.Size = new Size(187, 30);
            brandChooseLable.TabIndex = 1;
            brandChooseLable.Text = "Choose the Brand";
            // 
            // boardCheckedListBox
            // 
            boardCheckedListBox.BackColor = Color.FromArgb(64, 64, 64);
            boardCheckedListBox.BorderStyle = BorderStyle.None;
            boardCheckedListBox.CheckOnClick = true;
            boardCheckedListBox.ForeColor = Color.White;
            boardCheckedListBox.FormattingEnabled = true;
            boardCheckedListBox.Location = new Point(12, 71);
            boardCheckedListBox.Name = "boardCheckedListBox";
            boardCheckedListBox.Size = new Size(249, 378);
            boardCheckedListBox.TabIndex = 2;
            boardCheckedListBox.ItemCheck += boardCheckedListBox_ItemCheck;
            // 
            // selectedTreeView
            // 
            selectedTreeView.BackColor = Color.FromArgb(64, 64, 64);
            selectedTreeView.BorderStyle = BorderStyle.None;
            selectedTreeView.ForeColor = Color.White;
            selectedTreeView.Location = new Point(267, 71);
            selectedTreeView.Name = "selectedTreeView";
            selectedTreeView.Size = new Size(250, 372);
            selectedTreeView.TabIndex = 4;
            // 
            // selectedBoardsLable
            // 
            selectedBoardsLable.AutoSize = true;
            selectedBoardsLable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectedBoardsLable.ForeColor = Color.White;
            selectedBoardsLable.Location = new Point(267, 9);
            selectedBoardsLable.Name = "selectedBoardsLable";
            selectedBoardsLable.Size = new Size(168, 30);
            selectedBoardsLable.TabIndex = 1;
            selectedBoardsLable.Text = "Selected Boards";
            // 
            // saveSelectedBoardsButton
            // 
            saveSelectedBoardsButton.FlatStyle = FlatStyle.Flat;
            saveSelectedBoardsButton.ForeColor = Color.White;
            saveSelectedBoardsButton.Location = new Point(400, 449);
            saveSelectedBoardsButton.Name = "saveSelectedBoardsButton";
            saveSelectedBoardsButton.Size = new Size(117, 46);
            saveSelectedBoardsButton.TabIndex = 5;
            saveSelectedBoardsButton.Text = "Save selection";
            saveSelectedBoardsButton.UseVisualStyleBackColor = true;
            saveSelectedBoardsButton.Click += saveSelectedBoardsButton_Click;
            // 
            // closeButton
            // 
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(277, 449);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(117, 46);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close and delete selection";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Boards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(529, 507);
            Controls.Add(closeButton);
            Controls.Add(saveSelectedBoardsButton);
            Controls.Add(selectedTreeView);
            Controls.Add(boardCheckedListBox);
            Controls.Add(selectedBoardsLable);
            Controls.Add(brandChooseLable);
            Controls.Add(boardMarkeComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Boards";
            StartPosition = FormStartPosition.CenterParent;
            Text = "W.i.A Session Auto Mod Board select by ZennDev";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boardMarkeComboBox;
        private Label brandChooseLable;
        private CheckedListBox boardCheckedListBox;
        private TreeView selectedTreeView;
        private Label selectedBoardsLable;
        private Button saveSelectedBoardsButton;
        private Button closeButton;
    }
}