using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindSwap
{
    public class UIRenderer
    {
        public void Render(string guess, string result, bool hasWon)
        {
            var table = CreateResults(guess, result);
            Console.WriteLine(table);
            if (hasWon) Console.WriteLine("You win! :-)");
        }

        public string CreateResults(string guess, string mark)
        {
            return "Guess: " + guess + "\n" + "Mark: " + mark;
        }

        public void RenderSecretCode(string code)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(code);
            Console.ResetColor();
        }
    }
}
