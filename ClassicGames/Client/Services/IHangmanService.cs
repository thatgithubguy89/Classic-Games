namespace ClassicGames.Client.Services
{
    public interface IHangmanService
    {
        public string GetWord();
        public List<string> GetAlphabet();
        public List<string> GetImageList();
        public int LettersPicked(List<string> colorPicker);
        public string GameOverMessage(int colorCounter, string word, int counter);
    }
}
