using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindSwap
{
    public class CodeRandomiser
    {
        private const string ValidCodeCharacters = "rgycw";

        public string CreateCode()
        {
            var random = new Random();
            var code = new string(Enumerable.Repeat(ValidCodeCharacters, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            code =  string.Join<char>(",", code);
            return code;
        }
    }
}
