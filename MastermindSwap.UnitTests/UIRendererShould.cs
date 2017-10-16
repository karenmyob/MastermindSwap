using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MastermindSwap.UnitTests
{
    [TestFixture]
    public class UIRendererShould
    {
        [Test]
        public void CreateFeedbackTable()
        {
            var uiRenderer = new UIRenderer();
            const string guess = "r,g,y,c";
            const string mark = "b,b,b,b";
            const string expected = "Guess: r,g,y,c\nMark: b,b,b,b";

            var result = uiRenderer.CreateFeedbackTable(guess, mark);

            Assert.AreEqual(expected, result);
        }
    }
}
