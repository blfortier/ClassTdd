using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionSubtraction;

namespace FractionSubtraction.UnitTesting
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void CheckIfBothDenominatorsAreTheSame_ReturnSubtractedResult()
        {
            int[] firstFraction =  { 3, 4};
            int[] secondFraction = { 2, 4};
            int[] result =  { 1 , 4};

            var expected = result;
            var actual = Subtract.SubtractFractions(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfBothDenominatorsAreSame_ReturnsSubtractedAndReducedFraction()
        {
            int[] firstFraction = { 8, 10 };
            int[] secondFraction = { 6, 10}; 
            int[] result = { 1, 5 };

            var expected = result;
            var actual = Subtract.SubtractFractions(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckIfBothDenominatorsAredifferent_ReturnsSubtractedFraction()
        {
            int[] firstFraction = { 2, 5 };
            int[] secondFraction = { 1, 10 };
            int[] result = {3, 10 };

            var expected = result;
            var actual = Subtract.SubtractFractions(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CheckIfBothDenominatorsAredifferent_ReturnsSubtractedReducedFraction()
        {
            int[] firstFraction = { 2, 4};  // 18 / 36
            int[] secondFraction = { 5, 9 }; // 20 / 36  == -2 / 36 == -1 / 18
            int[] result = { -1, 18 };

            var expected = result;
            var actual = Subtract.SubtractFractions(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);

        }
    }
}
