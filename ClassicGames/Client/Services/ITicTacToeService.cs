namespace ClassicGames.Client.Services
{
    public interface ITicTacToeService
    {
        bool CheckIfGameIsOver(List<string> imgList, string player);
        int ComputerSelection(List<string> imgList);
        bool CheckAllSquares(List<string> imgList);
        string SetMessage(string winner);
    }
}
