using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteSpaceTrim.UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]

        public void CheckIfAStringIsNull_ReturnException()
        {
            string input = null;
            Assert.Throws<System.NullReferenceException>(() => TrimSpaces.CheckForWhiteSpace(input));
        }

        [Test]

        public void CheckIfAStringIsEmpty_ReturnException()
        {
            string input = "";
            Assert.Throws<System.ArgumentException>(() => TrimSpaces.CheckForWhiteSpace(input));
        }

        [Test]

        public void CheckForNoWhitespace_InAString()
        {
            string input = "abc";
            string expected = "abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void RemoveWhiteSpacesAtEndOfString()
        {
            string input = "abc    ";
            string expected = "abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void KeepsWhitespaceAtBeginningOfString()
        {
            string input = "   abc    ";
            string expected = "   abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckForTabsAndRemoveThemFromString()
        {
            string input = "abc\t ";
            string expected = "abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveWhiteSpaceInMiddleOfString()
        {
            string input = "abc\r\n cd \r\n ";
            string expected = "abc\r\ncd\r\n";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }


    }
}
