using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MastermindKata.Logic;

namespace MastermindSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            MastermindKata.Logic.Mastermind mastermind = new Mastermind(new GuessValidator());
            string secret = "r,g,y,c";
            string guess = "r,g,y,c"; // Can only guess using rgycw
            string mark = mastermind.ReturnMark(secret, guess);

            Console.WriteLine(secret + " " + guess + " " + mark);
        }
    }
}
