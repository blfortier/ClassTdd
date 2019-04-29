using NUnit.Framework;
using LotteryService;

namespace Tests
{
    public class Tests
    {

        Class1 _testService = new Class1();
        [Test]
        public void return_Array()
        {
            int[] lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0], output);
        }

        [Test]
        public void return_OneNumSorted()
        {
            int[] lotteryNumbers1 = { 1 };
            var output = _testService.SortNumbers(lotteryNumbers1);
            Assert.AreEqual(lotteryNumbers1, output);
        }

        [Test]
        public void return_twoNumSorted()
        {
            int[] lotteryNumbers2 = { 2, 1 };
            var output = _testService.SortNumbers(lotteryNumbers2);
            int[] expected = { 1, 2 };
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void return_threeNumSorted()
        {
            int[] lotteryNumbers2 = { 2, 5, 1 };
            var output = _testService.SortNumbers(lotteryNumbers2);
            int[] expected = { 1, 2, 5 };
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void return_tenNumSorted()
        {
            int[] lotteryNumbers2 = { 2, 5, 1, 7, 3, 12, 9, 13, 0, 8 };
            var output = _testService.SortNumbers(lotteryNumbers2);
            int[] expected = { 0, 1, 2, 3, 5, 7, 8, 9, 12, 13 };
            Assert.AreEqual(expected, output);
        }
    }
}