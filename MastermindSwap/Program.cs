using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using MastermindKata.Logic;

namespace MastermindSwap
{
    class Program
    {
        static void Main(string[] args)
        {     
            var codeChecker = new Mastermind(new GuessValidator());
            var inputCleanser = new InputCleanser();
            var uiWriter = new UIWriter();
            var codeRandomiser = new CodeRandomiser();

            var mastermindGame = new MastermindGame(codeChecker, codeRandomiser, uiWriter, inputCleanser);

            mastermindGame.Run();
        }
    }
}
