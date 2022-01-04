namespace ClassicGames.Client.Services
{
    public class RockPaperScissorsService : IRockPaperScissorsService
    {
        public string ComputerSelection()
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new();

            return choices[random.Next(2)];
        }

        public string PlayerSelection(string playerChoice)
        {
            switch (playerChoice)
            {
                case "images/rock.png":
                    playerChoice = "rock";
                    break;
                case "images/paper.png":
                    playerChoice = "paper";
                    break;
                case "images/scissors.png":
                    playerChoice = "scissors";
                    break;
            }

            return playerChoice;
        }

        public string SetMessage(string winner)
        {
            switch (winner)
            {
                case "player":
                    winner = "You won!!!";
                    break;
                case "computer":
                    winner = "You lost";
                    break;
                case "draw":
                    winner = "Draw";
                    break;
            }

            return winner;
        }
    }
}
