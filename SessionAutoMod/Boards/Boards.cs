using SessionAutoMod.DTO;
using System.Diagnostics;

namespace SessionAutoMod.Boards
{
    public partial class Boards : Form
    {
        private List<BoardBrand> boardBrand = new List<BoardBrand>();
        private List<BoardFile> selectedBoards = new List<BoardFile>();
        public List<BoardFile> BoardFilesReturn { get; set; } = new List<BoardFile>();

        public Boards()
        {
            InitializeComponent();
            Debug.WriteLine(selectedBoards.Count);

            string path = Config.ueViewerFolder + @"\UmodelExport\Game\Customization\Skateboards\DeckGraphics";
            try
            {
                foreach (string dir in Directory.EnumerateDirectories(path))
                {
                    boardBrand.Add(new BoardBrand(dir));
                }
                foreach (var brand in boardBrand)
                {
                    boardMarkeComboBox.Items.Add(brand.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "You need to export the Graphics");
                throw;
            }

        }
        public Boards(List<BoardFile> boardFiles)
            : this()
        {
            selectedBoards = boardFiles;
            Debug.WriteLine(selectedBoards.Count);
            UpdateSelectedTreeNode();
        }

        private void boardMarkeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            boardCheckedListBox.Items.Clear();

            boardBrand.ForEach(b =>
            {
                if (b.IsNameEqual(boardMarkeComboBox.SelectedItem.ToString()))
                {
                    b.boards.ForEach(bf =>
                    {
                        if (selectedBoards.Contains(bf))
                            boardCheckedListBox.Items.Add(bf.Name, true);
                        else
                            boardCheckedListBox.Items.Add(bf.Name);

                    });
                }
            });
        }

        private void boardCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemText = boardCheckedListBox.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                boardBrand.ForEach(brand =>
                {
                    if (brand.IsNameEqual(boardMarkeComboBox.Text))
                    {
                        brand.boards.ForEach(bf =>
                        {
                            if (bf.IsNameEqual(itemText))
                            {
                                if (!selectedBoards.Contains(bf))
                                    selectedBoards.Add(bf);
                            }
                        });
                    }
                });
            }
            else
            {
                boardBrand.ForEach(brand =>
                {
                    if (brand.IsNameEqual(boardMarkeComboBox.Text))
                    {
                        brand.boards.ForEach(bf =>
                        {
                            if (bf.IsNameEqual(itemText))
                            {
                                selectedBoards.Remove(bf);
                            }
                        });
                    }
                });
            }
            UpdateSelectedTreeNode();
        }
        private void UpdateSelectedTreeNode()
        {
            selectedTreeView.Nodes.Clear();
            List<string> selected = new List<string>();
            foreach (var item in selectedBoards)
            {
                if (!selected.Contains(item.BoardBrand.Name))
                    selected.Add(item.BoardBrand.Name);
            }
            foreach (var item in selected)
            {
                selectedTreeView.Nodes.Add(item).Name = item;

            }
            foreach (var item in selectedBoards)
            {
                int i = selectedTreeView.Nodes.IndexOfKey(item.BoardBrand.Name);
                selectedTreeView.Nodes[i].Nodes.Add(item.Name);
            }
            selectedTreeView.ExpandAll();
        }

        private void saveSelectedBoardsButton_Click(object sender, EventArgs e)
        {
            var sb = selectedBoards;
            this.BoardFilesReturn = sb;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            selectedBoards = new List<BoardFile>();
            BoardFilesReturn = new List<BoardFile>();
            var sb = selectedBoards;
            this.BoardFilesReturn = sb;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
