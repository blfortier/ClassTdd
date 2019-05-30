
using CheckForLetters;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumOfOccurrences.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {

        private StringUtils _stringUtils;

        [SetUp]
        public void SetupStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }

       [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            string sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            string charToScanFor = "n";
            int expectedResult = 5;

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        // or: [ExpectedException(typeof(ArgumentException))]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            string sentenceToScan = "This test should throw an exception";
            string charToScanFor = "xx";

            Assert.Throws<System.ArgumentException>(() => _stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor));
        }


        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            string sentenceToScan = "TDD is awesome!";
            string charToScanFor = "e";
            int expectedResult = 2;

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor);
            Assert.AreEqual(expectedResult, result);

        }
    
    }
}
