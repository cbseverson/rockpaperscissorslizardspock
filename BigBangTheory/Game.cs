using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheory
{
    class Game
    {
        public Players playerOne;
        public Players playerTwo;
        public Rules rules;
        public Rules playerOnePoints;
        public Rules playerTwoPoints;
        public int gameRound = 3;
        public int j;
        
        public Game()
        {
            rules = new Rules(); 
        }
        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Would you like to play against a player or a computer? Input player or computer");
            string input = Console.ReadLine();
            if (input == "player") {
                playerOne = new Players();
                playerTwo = new Players();
            }

            else if (input == "computer")
            {
                playerOne = new Players();
                playerTwo = new PlayerComputer();
            }

        }
        public void GameLoop()
        {
            for (j = 0; j < gameRound; j++)
            {
                Console.WriteLine(j);
            }
        }

        public void ChooseWinner()
        {
           if (playerOnePoints == 2)
            {
                Console.WriteLine("Player One Wins");
            }
           if (playerTwoPoints == 2)
            {
                Console.WriteLine("Player Two Wins");
            }
        }

        public void runGame()
        {
            //guideline - need to update based on choice
            Players choice = new Players();
            //choice.playerOn();
        }

    }
}
