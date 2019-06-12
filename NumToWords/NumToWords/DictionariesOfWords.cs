using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWords
{
    public class DictionariesOfWords
    {
        Dictionary<int, string> thousand_Hundred_OnesPlaceDigits = new Dictionary<int, string>
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

        Dictionary<int, string> tensPlaceDigits = new Dictionary<int, string>
        {
            [0] = "",
            [1] = "ten",
            [2] = "twenty",
            [3] = "thirty",
            [4] = "fourty",
            [5] = "fifty",
            [6] = "sixty",
            [7] = "seventy",
            [8] = "eighty",
            [9] = "ninety"
        };

        // if the tens place is a 1, the number in ones place

        Dictionary<int, string> teensDigits = new Dictionary<int, string>
        {
            [0] = "",
            [1] = "ten",
            [2] = "twelve",
            [3] = "thirteen",
            [4] = "fourteen",
            [5] = "fifteen",
            [6] = "sixteen",
            [7] = "seventeen",
            [8] = "eighteen",
            [9] = "nineteen"
        };



    }
}
