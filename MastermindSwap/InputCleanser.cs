using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MastermindSwap
{
    public class InputCleanser
    {
        public string Cleanse(string input)
        {
            var inputWithoutCommas = RemoveCommas(input);
            var trimmedInput = RemoveExtraCharacters(inputWithoutCommas);
            var inputSeparatedWithCommas = AddCommasBetweenCharacters(trimmedInput);
            return inputSeparatedWithCommas.ToLower();
        }

        private string RemoveCommas(string input)
        {
            return input.Replace(",", "");
        }

        private string AddCommasBetweenCharacters(string input)
        {
            return string.Join<char>(",", input);
        }

        private string RemoveExtraCharacters(string input)
        {
            return input.Substring(0, 4);
        }
    }
}
