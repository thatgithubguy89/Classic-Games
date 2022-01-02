namespace ClassicGames.Client.Repositories
{
    public interface IRockPaperScissorsRepository
    {
        string ComputerSelection();
        string PlayerSelection(string playerChoice);
        string SetMessage(string winner);
    }
}
