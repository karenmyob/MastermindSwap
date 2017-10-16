using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CodeBreaker.UnitTests;
using MastermindKata.Logic;

namespace MastermindSwap
{
    class Program
    {
        static void Main(string[] args)
        {       
            var mastermind = new Mastermind(new GuessValidator());
            var mark = "";
            const string code = "r,g,y,c";

            Console.WriteLine("Enter in your guess (4 characters, r g y c w)");
            while (!mastermind.CheckWinCondition(mark))
            {
                try
                {
                    var input = Console.ReadLine();
                    var guess = CleanseInput(input);
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


        public static string CleanseInput(string input)
        {
            return string.Join<char>(",", input.ToLower());  
        }

    }
}
