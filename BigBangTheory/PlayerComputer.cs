using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheory
{
    public class PlayerComputer: Players
    {
        public int Rock = 1;
        public int Paper = 2;
        public int Scissors = 3;
        public int Lizard = 4;
        public int Spock = 5;
        public int computerChoice;
    
    public override void playerTwoPrompt()
        {   
            computerChoice = rand() % 5 + 1;

            switch ()
            {
                case Rock:
                    Console.WriteLine("Computer choice is Rock");
                break;
                case Paper:
                    Console.WriteLine("Computer choice is Paper");
                break;
                case Scissors:
                    Console.WriteLine("Computer choice is Scissors");
                break;
                case Lizard:
                    Console.WriteLine("Computer choice is Lizard");
                break;
                case Spock:
                    Console.WriteLine("Computer choice is Lizard");
                break;
                default:
                break;
            }
        } 
    }
}
