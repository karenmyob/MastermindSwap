using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastermindKata.Logic;

namespace MastermindSwap
{
    class MastermindGame
    {
        public void StartGame()
        {
            var mastermind = new Mastermind(new GuessValidator());
            var inputCleanser = new InputCleanser();
            var mark = "";
            const string code = "r,g,y,c";

            Console.WriteLine("Enter in your guess (4 characters, r g y c w)");
            while (!mastermind.CheckWinCondition(mark))
            {
                try
                {
                    var input = Console.ReadLine();
                    var guess = inputCleanser.AddCommas(input);
                    mark = mastermind.ReturnMark(code, guess);
                    Console.WriteLine(mark.Equals("") ? "----" : mark);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Please enter 4 characters");
                }
            }

            Console.WriteLine("You win! :-)");
        }


    }
}
