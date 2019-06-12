using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWords
{
    public class Converter
    {
        

        public static string ConvertFromNumToWords(int numToConvert)
        {
            String wordEquiv = "";

            Dictionary<int, string> singleDigits = new Dictionary<int, string>
            {
                [0] = "zero",
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine"
            };

            if (singleDigits.ContainsKey(numToConvert))
                wordEquiv = singleDigits[numToConvert];

            return wordEquiv;
        }

        public static int ReturnNumberOfDigitsInNum(int number)
        {
            return number.ToString().Length;
        }
    }
}
