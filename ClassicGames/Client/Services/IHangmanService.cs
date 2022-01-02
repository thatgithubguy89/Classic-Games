namespace ClassicGames.Client.Services
{
    public interface IHangmanService
    {
        public string GetWord();
        public List<string> GetAlphabet();
        public List<string> GetImageList();
    }
}
