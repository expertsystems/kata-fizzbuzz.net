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
        public void TwoReturnsTwo()
        {
            LOG.Info("Arrange");
            

            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(2);

            LOG.Info("Assert");
            Assert.AreEqual("2", result);
        }

        [Test]
        public void OneReturnsOne()
        {
            LOG.Info("Arrange");


            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(1);

            LOG.Info("Assert");
            Assert.AreEqual("1", result);
        }

        [Test]
        public void ThreeReturnsFizz()
        {
            LOG.Info("Arrange");


            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(3);

            LOG.Info("Assert");
            Assert.AreEqual("Fizz", result);
        }


        [Test]
        public void NineReturnsFizz()
        {
            LOG.Info("Arrange");


            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(9);

            LOG.Info("Assert");
            Assert.AreEqual("Fizz", result);
        }


        [Test]
        public void TenReturnsBuzz()
        {
            LOG.Info("Arrange");


            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(10);

            LOG.Info("Assert");
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void ThirtyReturnsFizzBuzz()
        {
            LOG.Info("Arrange");


            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(30);

            LOG.Info("Assert");
            Assert.AreEqual("FizzBuzz", result);
        }


        [Test]
        public void ThirteenReturnsFizz()
        {
            LOG.Info("Arrange");


            LOG.Info("Act");
            FizzBuzz fb = new FizzBuzz();
            String result = fb.fizzbuzz(13);

            LOG.Info("Assert");
            Assert.AreEqual("Fizz", result);
        }
    
    }

}