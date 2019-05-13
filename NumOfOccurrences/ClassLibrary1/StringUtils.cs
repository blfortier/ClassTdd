using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForLetters
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentence, string charToFind)
        {
            if (charToFind.Length != 1)
                throw new ArgumentException();

            int numOfOccurrences = 0;
            char[] stringToCheckAsCharacterArray = sentence.ToCharArray();
            char stringToChar = Convert.ToChar(charToFind);
            for (int charIndex = 0; charIndex < stringToCheckAsCharacterArray.GetUpperBound(0); charIndex++)
            {
                if (stringToCheckAsCharacterArray[charIndex] == stringToChar)
                    numOfOccurrences++;
            }
            return numOfOccurrences;
        }
    }
}
