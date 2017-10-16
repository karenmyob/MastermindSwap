using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindSwap
{
    public class UIRenderer
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string CreateFeedbackTable(string guess, string mark)
        {
            return "Guess: " + guess + "\n" + "Mark: " + mark;
        }
    }
}
