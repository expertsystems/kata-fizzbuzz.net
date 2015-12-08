using System;
using Common.Logging;
using NUnit.Framework;

namespace FizzBuzz
{
    [SetUpFixture]
    class LogSetup
    {
        [SetUp]
        public static void ConfigureLogging()
        {
            Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter();
            LogManager.GetLogger(typeof(LogSetup)).Info("Console logging configured");
        }
    }
}
