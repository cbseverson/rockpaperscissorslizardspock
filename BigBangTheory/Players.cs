using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangTheory
{
    public class Players
    {
        public string playerType;
        public string playerOne;
        public string playerTwo;

    virtual public void playerOnePrompt()
        {
            Console.WriteLine("Choose one: Rock, Paper, Scissors, Lizard, Spock");
            string userOneChoice = Console.ReadLine();
        }
    virtual public void playerTwoPrompt()
        {
            Console.WriteLine("Choose one: Rock, Paper, Scissors, Lizard, Spock");
            string userTwoChoice = Console.ReadLine();
        }       
    }
}
