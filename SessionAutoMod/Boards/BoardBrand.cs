using SessionAutoMod.DTO;

namespace SessionAutoMod.Boards
{
    public class BoardBrand
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<BoardFile> boards { get; set; }

        public BoardBrand(string path)
        {

            Path = path;
            string[] dirName = path.Split("\\");
            Name = dirName.Last();
            boards = new List<BoardFile>();
            GetAllBoards();
        }

        private void GetAllBoards()
        {
            string path = Config.ueViewerFolder + @"\UmodelExport\Game\Customization\Skateboards\DeckGraphics\" + Name;
            foreach (string file in Directory.EnumerateFiles(path))
            {
                boards.Add(new BoardFile(this, file));
            }
            string texturePath = Config.ueViewerFolder + @"\UmodelExport\Game\Customization\Skateboards\DeckGraphics\" + Name + @"\Textures";
            if (Directory.Exists(texturePath))
            {
                foreach (string file in Directory.EnumerateFiles(texturePath))
                {
                    boards.Add(new BoardFile(this, file));
                }
            }

        }
        /// <summary>
        /// Methode to check if name of brand is equal
        /// </summary>
        /// <param name="name">String</param>
        /// <returns></returns>
        public bool IsNameEqual(string name)
        {
            if (name == Name) return true;
            return false;
        }
    }
}
