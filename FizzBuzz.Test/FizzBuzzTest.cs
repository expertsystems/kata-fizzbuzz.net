using System;
using Common.Logging;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private static ILog LOG;

        [SetUp]
        public static void ConfigureLogging() 
        {
            Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter();
            LOG = LogManager.GetLogger(typeof(FizzBuzzTest));
        }


        [Test]
        public void LogTest()
        {
            LOG.Info("Test!");
        }
    }
}