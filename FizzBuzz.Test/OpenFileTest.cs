using System;
using Common.Logging;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Collections;



namespace FizzBuzz
{
    /// <summary>
    /// Testcases for OpenFile class. 
    /// </summary>
    /// 
    [TestFixture]
    class OpenFileTest
    {
        private static ILog LOG = LogManager.GetLogger(typeof(OpenFileTest));

        [Test]
        public void ParseXmlWithMultipleDataTags()
        {
            LOG.Info("Arrange");
            XmlDocument testDoc = new XmlDocument();
            testDoc.InnerXml = "<root>" +
                               "<data>ABCDA</data>" +
                               "<data>123</data>" +
                                "<data>456</data>" +
                                 "<ignoreMe>IGNORED</ignoreMe>" +
                             "</root>";

            LOG.Info("Act");
            OpenFile of = new OpenFile();
            IList<string> output = of.ParseXml(testDoc);
            
            LOG.Info("Assert");

            LOG.Info(output.ToString());
            ArrayList expected = new ArrayList();
            expected.Add("ABCDA");
            expected.Add("123");
            expected.Add("456");
            LOG.Info("Expected output: " + string.Join(", ", expected.ToArray()));
            // LOG.Info("Actual output: " + string.Join(", ", new ArrayList<String>(output).ToArray()));
            CollectionAssert.AreEqual(expected, output);
            
        }

        [Test]
        public void ParseXmlWithNoDataTags()
        {
            LOG.Info("Arrange");
            XmlDocument testDoc = new XmlDocument();
            testDoc.InnerXml = "<root>" +
                               "<ignoreMe>IGNORED</ignoreMe>" +
                               "</root>";

            LOG.Info("Act");
            OpenFile of = new OpenFile();
            IList<string> output = of.ParseXml(testDoc);

            LOG.Info("Assert");

            CollectionAssert.IsEmpty(output);

        }

        [Test]
        public void CountCharacters()
        {
            LOG.Info("Arrange");
            String test = "ABCDA";

            LOG.Info("Act");
            CharCounter charCounter = new CharCounter();
            Dictionary<char, int> countChar = charCounter.CountCharacters(test);

            LOG.Info("Assert");

            Assert.AreEqual(2, countChar['A']);
            Assert.AreEqual(1, countChar['B']);
            Assert.AreEqual(1, countChar['C']);
            Assert.AreEqual(1, countChar['D']);


        }

        [Test]
        public void CountCharacters_EmptyString()
        {
            LOG.Info("Arrange");
            String test = null;

            LOG.Info("Act");
            CharCounter charCounter = new CharCounter();
            Dictionary<char,int> countChar = charCounter.CountCharacters(test);

            LOG.Info("Assert");
            Assert.IsEmpty(countChar);
        
        }

        [Test]
        public void FileCharacterCounter_CountCharacters()
        {
            FileCharacterCounter fileCharacterCounter = new FileCharacterCounter();

            OpenFile fileReader = Substitute.For<OpenFile>();
            fileCharacterCounter.MyFileReader = fileReader;

            CharCounter characterCounter = Substitute.For<CharCounter>();
            fileCharacterCounter.MyCharCounter = characterCounter;

            XmlDocument testDoc = new XmlDocument();

            // Pretend we have an XML file with 2 lines "AB" and "BC"
            IList<string> readLines = new System.Collections.Generic.List<string>();
            readLines.Add("fake-line-1");
            readLines.Add("fake-line-2");
            fileReader.ParseXml(testDoc).Returns(readLines);

            // Mock characterCounter
            var dict1 = new Dictionary<Char,int >();
            dict1['A'] = 1;
            dict1['B'] = 1;
            characterCounter.CountCharacters("fake-line-1").Returns(dict1);

            var dict2 = new Dictionary<Char, int>();
            dict2['B'] = 1;
            dict2['C'] = 1;

            characterCounter.CountCharacters("fake-line-2").Returns(dict2);
            

            Dictionary<char,int> result = fileCharacterCounter.CountCharacters(testDoc);

            Assert.AreEqual(1, result['A']);
            Assert.AreEqual(2, result['B']);
            Assert.AreEqual(1, result['C']);

            

        }

    }

}
