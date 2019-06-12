using NumToWords;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class NumToWordsTests
    {
        // public Converter _convert = new Converter();
        int num;

        [Test]
        public void ReturnNumberOfDigitsInNumber_ThreeDigits_ShouldReturnThree()
        {
            num = 100;

            int expected = 3;
            int actual = Converter.ReturnNumberOfDigitsInNum(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNumberIs0_ReturnZero()
        {
            num = 0;

            string expected = "zero";
            string actual = Converter.ConvertFromNumToWords(num);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNumberIs2_ReturnTwo()
        {
            num = 2;

            string expected = "two";
            string actual = Converter.ConvertFromNumToWords(num);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfNumberIs8_ReturnEight()
        {
            num = 8;

            string expected = "eight";
            string actual = Converter.ConvertFromNumToWords(num);

            Assert.AreEqual(expected, actual);
        }


    }           
}
