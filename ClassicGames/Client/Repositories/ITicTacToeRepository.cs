namespace ClassicGames.Client.Repositories
{
    public interface ITicTacToeRepository
    {
        bool CheckIfGameIsOver(List<string> imgList, string player);
        int ComputerSelection(List<string> imgList);
        bool CheckAllSquares(List<string> imgList);
        string SetMessage(string winner);
    }
}
