namespace ClassicGames.Client.Services
{
    public interface IRockPaperScissorsService
    {
        string ComputerSelection();
        string PlayerSelection(string playerChoice);
        string SetMessage(string winner);
    }
}
