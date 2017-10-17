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
            Mastermind codeChecker = new Mastermind(new GuessValidator());
            InputCleanser inputCleanser = new InputCleanser();
            UIRenderer uiRenderer = new UIRenderer();
            var mastermindGame = new MastermindGame(codeChecker, uiRenderer, inputCleanser);
            mastermindGame.StartGame();
        }
    }
}
