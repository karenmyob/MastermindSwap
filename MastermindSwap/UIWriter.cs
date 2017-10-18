using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindSwap
{
    public class UIWriter
    {
        private const string Instructions = "Enter in your guess (4 characters, Valid characters: r g y c w)";
        private const string WinMessage = "You win! :-)";

        public void WriteResult(string guess, string result)
        {
            var table = CreateResultMessage(guess, result);
            Console.WriteLine(table);
        }
        public string CreateResultMessage(string guess, string mark)
        {
            return "Guess: " + guess + "\n" + "Mark: " + mark;
        }

        public void WriteWinMessage()
        {
            Console.WriteLine(WinMessage);
        }

        public void WriteInstructions()
        {
            Console.WriteLine(Instructions);
        }

        public void WriteSecretCode(string code)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(code);
            Console.ResetColor();
        }
    }
}
