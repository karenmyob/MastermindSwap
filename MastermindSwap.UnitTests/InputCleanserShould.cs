using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MastermindSwap.UnitTests
{
    [TestFixture]
    public class InputCleanserShould
    {

        [Test]
        public void EnsureOnlySingleCommasBetweenCharacters()
        {
            InputCleanser inputCleanser = new InputCleanser();
            Assert.AreEqual("r,g,y,c", inputCleanser.Cleanse("rgyc"));
            Assert.AreEqual("r,g,y,c", inputCleanser.Cleanse("r,g,y,c"));
            Assert.AreEqual("r,g,y,c", inputCleanser.Cleanse("r,,g,,y,,c"));
            Assert.AreEqual("r,g,y,c", inputCleanser.Cleanse(",r,,g,,,y,c,"));
        }
    }
}
