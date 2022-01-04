namespace ClassicGames.Client.Services
{
    public class TicTacToeService : ITicTacToeService
    {
        public bool CheckIfGameIsOver(List<string> imgList, string player)
        {
            if ((imgList[0] == $"images/{player}.png") && (imgList[4] == $"images/{player}.png") && (imgList[8] == $"images/{player}.png"))
            {
                return true;
            }
            else if ((imgList[1] == $"images/{player}.png") && (imgList[4] == $"images/{player}.png") && (imgList[7] == $"images/{player}.png"))
            {
                return true;
            }
            else if ((imgList[2] == $"images/{player}.png") && (imgList[4] == $"images/{player}.png") && (imgList[6] == $"images/{player}.png"))
            {
                return true;
            }
            else if ((imgList[0] == $"images/{player}.png") && (imgList[1] == $"images/{player}.png") && (imgList[2] == $"images/{player}.png"))
            {
                return true;
            }
            else if ((imgList[3] == $"images/{player}.png") && (imgList[4] == $"images/{player}.png") && (imgList[5] == $"images/{player}.png"))
            {
                return true;
            }
            else if ((imgList[6] == $"images/{player}.png") && (imgList[7] == $"images/{player}.png") && (imgList[8] == $"images/{player}.png"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // This method selects a random empty square for the computer
        public int ComputerSelection(List<string> imgList)
        {
            Random random = new();
            bool check = false;
            int index = 0;

            while (!check) // While check is false
            {
                int randomNumber = random.Next(8); // Select a random number between 0 and 8

                if (imgList[randomNumber] != "images/blank.png") // If the selected square is not empty
                {
                    check = false; // Start over
                }
                else
                {
                    index = randomNumber; // Set index equal to the random number
                    check = true; // End the loop
                }
            }

            return index; // Return the random number
        }

        // This methods checks if 8 squares have been selected
        public bool CheckAllSquares(List<string> imgList)
        {
            int counter = 0;

            foreach (var item in imgList)
            {
                if (item != "images/blank.png")
                    counter++;
            }

            if (counter == 8)
                return true;

            return false;
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
