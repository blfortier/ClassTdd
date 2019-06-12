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
