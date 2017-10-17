using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MastermindSwap.UnitTests
{
    [TestFixture]
    public class InputCleanserShould
    {
        private InputCleanser _inputCleanser;

        [SetUp]
        public void SetUp()
        {
            _inputCleanser = new InputCleanser();
        }

        [Test]
        public void AddCommas()
        {
            Assert.AreEqual("r,g,y,c", _inputCleanser.Cleanse("rgyc"));
        }
    }
}
