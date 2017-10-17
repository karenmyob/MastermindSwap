using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastermindKata.Logic;

namespace MastermindSwap
{
    class MastermindGame
    {
        private string _code;
        private string _mark;
        private Mastermind _mastermind;
        private UIRenderer _uiRenderer;
        private InputCleanser _inputCleanser;

        public MastermindGame(Mastermind codeChecker, UIRenderer uiRenderer, InputCleanser inputCleanser)
        {
            _mastermind = codeChecker;
            _uiRenderer = uiRenderer;
            _inputCleanser = inputCleanser;
            _mark = "";
        }

        public void StartGame()
        {
            _code = CreateCode();
            _uiRenderer.PrintMessage("Enter in your guess (4 characters, r g y c w)");

            while (!_mastermind.CheckWinCondition(_mark))
            {
                try
                {
                    var input = Console.ReadLine();
                    var guess = _inputCleanser.AddCommas(input);

                    _mark = _mastermind.ReturnMark(_code, guess);
                    Console.WriteLine(_mark.Equals("") ? "----" : _mark);
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

        private string CreateCode()
        {
             return "r,g,y,c";
        }
    }
}
