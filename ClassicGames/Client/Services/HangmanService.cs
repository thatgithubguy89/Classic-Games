namespace ClassicGames.Client.Services
{
    public class HangmanService : IHangmanService
    {
        public string GetWord()
        {
            Random random = new Random();

            List<string> words = new List<string>() { "toad", "frog", "lion", "parrot", "whale", "dolphin", "tiger", "eagle" };

            return words[random.Next(words.Count() - 1)];
        }

        public List<string> GetAlphabet()
        {
            List<string> alphabet = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
                                                "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            return alphabet;
        }

        public List<string> GetImageList()
        {
            List<string> imgList = new List<string>() { "images/blank.png", "images/hm1.png", "images/hm2.png",
                                                        "images/hm3.png", "images/hm4.png", "images/hm5.png", "images/hm6.png" };

            return imgList;
        }
    }
}
