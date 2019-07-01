using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpandedForm;

namespace ExpandedForm.UnitTesting
{
    [TestFixture]
    public class ExpandedFormTests
    {
        [Test]
        public void IfLengthIsOne_ReturnNumber()
        {
            long number = 1;
            string expected = "1";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfLengthIsTwo_ReturnTensPlusOnes()
        {
            long number = 21;
            string expected = "20 + 1";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfLengthIsTwoAndOnePlaceIsZero_ReturnTensOnly()
        {
            long number = 20;
            string expected = "20";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfLengthIsThreeAndThereAreNoZeros_ReturnHundredsTensAndOnes()
        {
            long number = 375;
            string expected = "300 + 70 + 5";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfLengthIsMoreThanThreeAndNoZeros_ReturnHundredsTensAndOnes()
        {
            long number = 54213;
            string expected = "50000 + 4000 + 200 + 10 + 3";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfLengthIsMoreThanThreeAndHasZeros_ReturnHundredsTensAndOnes()
        {
            long number = 54203;
            string expected = "50000 + 4000 + 200 + 3";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfOnlyFirstDigitIsANumberNotEqualToZero_ReturnExpectedOutput()
        {
            long number = 9000000;
            string expected = "9000000";
            string actual = Expander.ExpandNumber(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
