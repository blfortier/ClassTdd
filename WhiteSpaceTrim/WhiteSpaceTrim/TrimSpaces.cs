using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteSpaceTrim
{
    public class TrimSpaces
    {
        public static string CheckForWhiteSpace(string input)
        {

            char[] charsToRemove = { ' ', '\t' };
            if (input == null)
                throw new NullReferenceException();

            if (input == string.Empty)
                throw new ArgumentException();

            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    word.TrimEnd(charsToRemove);
                }

            }


            //return  input.Replace(" ", "");


            return string.Join("", words);//input.TrimEnd(charsToRemove);


        }

    }
}
