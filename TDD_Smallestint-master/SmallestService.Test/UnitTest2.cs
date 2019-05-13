using NUnit.Framework;
using SmallestService;
using System;

namespace Tests
{
    public class Tests2
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }

        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var finder = new Finder();
            var input = new int[1] { 1 };
            var expectedResult = finder.FindClosestIntToZero(input);
            var actualResults = 1;
            Assert.AreEqual(expectedResult, actualResults);
        }

        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            var input = new int[2] { 2, 3 };
            var expectedResult = finder.FindClosestIntToZero(input);
            var actualResults = 2;
            Assert.AreEqual(expectedResult, actualResults);
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var finder = new Finder();
            var input = new int[3] { 5, 3, 2};
            var expectedResult = finder.FindClosestIntToZero(input);
            var actualResults = 2;
            Assert.AreEqual(expectedResult, actualResults);
        }

        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var finder = new Finder();
            var input = new int[4] { 7, 8, 3, -1 };
            var expectedResult = finder.FindClosestIntToZero(input);
            var actualResults = -1;
            Assert.AreEqual(expectedResult, actualResults);
        }

        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var finder = new Finder();
            var input = new int[5] { 7, -7, 8, 9, -8 };
            var expectedResult = finder.FindClosestIntToZero(input);
            var actualResults = -7;
            Assert.AreEqual(expectedResult, actualResults);
        }
    }
}