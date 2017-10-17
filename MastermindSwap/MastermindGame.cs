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
        private readonly Mastermind _mastermind;
        private readonly UIRenderer _uiRenderer;
        private readonly InputCleanser _inputCleanser;

        public MastermindGame(Mastermind codeChecker, UIRenderer uiRenderer, InputCleanser inputCleanser)
        {
            _mastermind = codeChecker;
            _uiRenderer = uiRenderer;
            _inputCleanser = inputCleanser;
        }

        public void StartGame()
        {
            var code = CreateCode();
            var hasWon = false;

            _uiRenderer.RenderSecretCode(code);
            Console.WriteLine("Enter in your guess (4 characters, r g y c w)");

            while (!hasWon)
            {
                var input = Console.ReadLine();
                var guess = _inputCleanser.Cleanse(input);
                var result = GetResult(code, guess);
                hasWon = _mastermind.CheckWinCondition(result);
                _uiRenderer.Render(guess, result, hasWon);
            }
        }

        private string GetResult(string code, string guess)
        {
            try
            {
                return _mastermind.ReturnMark(code, guess);
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
            catch (IndexOutOfRangeException)
            {
                return "Please enter four characters";
            }
        }

        private string CreateCode()
        {
            const string chars = "rgycw";
            var random = new Random();
            var code = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            code = _inputCleanser.Cleanse(code);
            return code;
        }
    }
}
