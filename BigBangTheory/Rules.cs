using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheory
{
    class Rules
    {
        public string one = "rock";
        public string two = "paper";
        public string three = "scissors";
        public string four = "lizard";
        public string five = "spock";
        public string userOneChoice;
        public string userTwoChoice;
        public int playerOnePoints;
        public int playerTwoPoints;
        public void AlertUser()
        {
            Console.WriteLine("Rules for Rock, Paper, Scissors, Lizard, Spock: /n Scissors cuts Paper /n Paper covers Rock /n Rock crushes Lizard /n Lizard poisons Spock /n Spock smashes Scissors /n Scissors decapitates Lizard /n Lizard eats Paper /n Paper disproves Spock /n Spock vaporizes Rock / (and as it always has) Rock crushes Scissors");
        }
        public Rules()
        {
            if (userOneChoice == "Paper" && userTwoChoice == "Rock" || userTwoChoice == "Spock")
            {
                Console.WriteLine("Player 1 Wins!");
                playerOnePoints++;
            }

            else if (userOneChoice == "Scissors" && userTwoChoice == "Paper" || userTwoChoice == "Lizard")
            {
                Console.WriteLine("Player 1 Wins!");
                playerOnePoints++;
            }
            else if (userOneChoice == "Rock" && userTwoChoice == "Lizard" || userTwoChoice == "Scissors")
            {
                Console.WriteLine("Player 1 Wins!");
                playerOnePoints++;
            }
            else if (userOneChoice == "Lizard" && userTwoChoice == "Spock" || userTwoChoice == "Paper")
            {
                Console.WriteLine("Player 1 Wins!");
                playerOnePoints++;
            }
            else if (userOneChoice == "Spock" && userTwoChoice == "Scissors" || userTwoChoice == "Rock")
            {
                Console.WriteLine("Player 1 Wins!");
                playerOnePoints++;
            }
            else if (userTwoChoice == "Paper" && userOneChoice == "Rock" || userOneChoice == "Spock")
            {
                Console.WriteLine("Player 1 Wins!");
                playerTwoPoints++;
            }

            else if (userTwoChoice == "Scissors" && userOneChoice == "Paper" || userOneChoice == "Lizard")
            {
                Console.WriteLine("Player 1 Wins!");
                playerTwoPoints++;
            }
            else if (userTwoChoice == "Rock" && userOneChoice == "Lizard" || userOneChoice == "Scissors")
            {
                Console.WriteLine("Player 1 Wins!");
                playerTwoPoints++;
            }
            else if (userTwoChoice == "Lizard" && userOneChoice == "Spock" || userOneChoice == "Paper")
            {
                Console.WriteLine("Player 1 Wins!");
                playerTwoPoints++; 
            }
            else if (userTwoChoice == "Spock" && userOneChoice == "Scissors" || userOneChoice == "Rock")
            {
                Console.WriteLine("Player 1 Wins!");
                playerTwoPoints++;
            }
            else if (userOneChoice == one && userTwoChoice == one)
            {
                Console.WriteLine("The score is a tie");
                playerOnePoints++;
                playerTwoPoints++;
            }
            else if (userOneChoice == two && userTwoChoice == two)
            {
                Console.WriteLine("The score is a tie");
                playerOnePoints++;
                playerTwoPoints++;
            }
            else if (userOneChoice == three && userTwoChoice == three)
            {
                Console.WriteLine("The score is a tie");
                playerOnePoints++;
                playerTwoPoints++;
            }
            else if (userOneChoice == four && userTwoChoice == four)
            {
                Console.WriteLine("The score is a tie");
                playerOnePoints++;
                playerTwoPoints++;
            }
            else if (userOneChoice == five && userTwoChoice == five)
            {
                Console.WriteLine("The score is a tie");
                playerOnePoints++;
                playerTwoPoints++;
            }
        }
    }
}
