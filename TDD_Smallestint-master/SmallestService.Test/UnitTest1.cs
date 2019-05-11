using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            var finder = new Finder();
            var input = new int[1] { 5 };
            var output = finder.FindSmallestInt(input);
            var expected = 5;
            Assert.AreEqual(output, expected);
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[2] { 5, 3 };
            var output = finder.FindSmallestInt(input);
            var expected = 3;
            Assert.AreEqual(output, expected);
        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[3] { 5, 3, 2 };
            var output = finder.FindSmallestInt(input);
            var expected = 2;
            Assert.AreEqual(output, expected);
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var finder = new Finder();
            var input = new int[4] { 5, 3, 2, 4 };
            var output = finder.FindSmallestInt(input);
            var expected = 2;
            Assert.AreEqual(output, expected);
        }
    }
}