namespace SessionAutoMod.Boards
{
    public class BoardFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public BoardBrand BoardBrand { get; set; }

        public BoardFile(BoardBrand boardBrand, string path)
        {
            Path = path;
            string[] dirName = path.Split("\\");
            Name = dirName.Last();
            BoardBrand = boardBrand;
        }

        /// <summary>
        /// Methode to check if name of board ist equal
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsNameEqual(string name)
        {
            if (name == Name) return true;
            return false;
        }
    }
}
