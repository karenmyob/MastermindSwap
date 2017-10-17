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
            input = RemoveCommas(input);
            return string.Join<char>(",", input.ToLower());
        }

        private string RemoveCommas(string input)
        {
            return input.Replace(",", "");
        }
    }
}
