﻿using System;
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
        private readonly UIWriter _uiWriter;
        private readonly InputCleanser _inputCleanser;
        private readonly CodeRandomiser _codeRandomiser;

        public MastermindGame(Mastermind codeChecker, CodeRandomiser codeRandomiser, UIWriter uiWriter, InputCleanser inputCleanser)
        {
            _mastermind = codeChecker;
            _uiWriter = uiWriter;
            _inputCleanser = inputCleanser;
            _codeRandomiser = codeRandomiser;
        }

        public void Run()
        {
            var code = _codeRandomiser.CreateCode();
            SetupGame(code);
            StartGame(code);
        }

        private void SetupGame(string code)
        {
            _uiWriter.WriteSecretCode(code);
            _uiWriter.WriteInstructions();
        }

        private void StartGame(string code)
        {
            var result = "";

            while (!HasWon(result))
            {
                var input = Console.ReadLine();
                var guess = _inputCleanser.Cleanse(input);

                result = GetResult(code, guess);
                _uiWriter.WriteResult(guess, result);
            }

            _uiWriter.WriteWinMessage();
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

        private bool HasWon(string result)
        {
            return _mastermind.CheckWinCondition(result);
        }
    }
}
