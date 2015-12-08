using System;
using Common.Logging;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private static ILog LOG = LogManager.GetLogger(typeof(FizzBuzzTest));

        [Test]
        public void FirstTest()
        {
            LOG.Info("Arrange");

            LOG.Info("Act");

            LOG.Info("Assert");
        }
    }
}