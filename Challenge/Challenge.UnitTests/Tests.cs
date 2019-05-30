using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrap.UnitTests
{
    [TestFixture]
    public class Tests
    {
        BreakSentence test = new BreakSentence();

        [Test]
        public void ReturnEmptyStringIfPassedAnEmptyString()
        {
            string testString = "";
            int testCol = 10;

            string expected = "";
            var actual = test.Wrapper(testString, testCol);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfIntIsEqualToSingleWord_ReturnWord()
        {
            string testString = "Hello";
            int testCol = 5;

            string expected = "Hello";
            var actual = test.Wrapper(testString, testCol);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnSentenceWithNewLineIfOnlyTwoWords()
        {
            string testString = "Hello there";
            int testCol = 5;

            string expected = "Hello\nthere";
            var actual = test.Wrapper(testString, testCol);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddNewLinesToLongSentenceEveryColumnInt()
        {
            string testString = "A little fox becomes best friends with a hunting dog.";
            int testCol = 9;

            string expected = "A little\n fox beco\nmes best\n friends\n with a h\nunting do\ng.";
            var actual = test.Wrapper(testString, testCol);

            Assert.AreEqual(expected, actual);
        }


        //[Test]
        //public void IfStringIsMoreThanOneWordBreakAfterWord()
        //{
        //    string testString = "Hello World";
        //    int testCol = 5;

        //    string expected = "Hello\nWorld";
        //    var actual = test.Wrapper(testString, testCol);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void IfIntIsLessThanSentenceLength_ReturnString()
        //{
        //    string testString = "Dictionary";
        //    int testCol = 5;

        //    string expected = "Dictionary";
        //    var actual = test.Wrapper(testString, testCol);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void IfStringContainsThreeWordsBreakAfterEachWord()
        //{
        //    string testString = "a b c";
        //    int testCol = 1;

        //    string expected = "a\nb\nc";
        //    var actual = test.Wrapper(testString, testCol);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void IfThereAreThreeWordsAndFirstTwoWordsIsLessThanInt_BreakAfterSecondWord()
        //{
        //    string testString = "the dog runner";
        //    int testCol = 10;

        //    string expected = "the dog\nrunner";
        //    var actual = test.Wrapper(testString, testCol);

        //    Assert.AreEqual(expected, actual);
        //}
    }
}

