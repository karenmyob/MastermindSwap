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
        public string AddCommas(string input)
        {
            return string.Join<char>(",", input.ToLower());
        }
    }
}
