using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MastermindSwap.UnitTests
{
    [TestFixture]
    public class UIWriterShould
    {
        [Test]
        public void CreateResultsWithGuessAndMark()
        {
            var uiRenderer = new UIWriter();
            const string guess = "r,g,y,c";
            const string mark = "b,b,b,b";
            const string expected = "Guess: r,g,y,c\nMark: b,b,b,b";

            var result = uiRenderer.CreateResultMessage(guess, mark);

            Assert.AreEqual(expected, result);
        }
    }
}
