using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrap
{
    public class BreakSentence
    {
        public string Wrapper(string sentence, int columnNumber)
        {
            // (!sentence.Contains(' ') && 


            if (sentence.Length == 0 || columnNumber == sentence.Length)
                return sentence;

            var sb = new StringBuilder(sentence);
            int counter = 0;

            Console.WriteLine(3 % 9);

            while (counter != columnNumber)
            {
                for (int i = 0; i < sentence.Length; i++)
                {

                }
            }


            //if (sentence.Length > columnNumber)
            //{
            //    if ((columnNumber ))
            //    {
            //        sb[columnNumber] = '\n';

            //    }
            //}
            return sb.ToString();

            //StringBuilder copyOfString = new StringBuilder(sentence);


            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (i == columnNumber)
            //    {
            //        // sentence.Replace(sentence[i], '\n');
            //        copyOfString[i] = '\n';
            //        Console.WriteLine(copyOfString.ToString());
            //    }
            //}

            ////for (var i = 0; i < sentence.Length; i++)
            ////{
            ////    if (sentence[i] == ' ')
            ////    {
            ////        sentence.Replace(sentence[i], '\n');
            ////    }
            ////}


            return sentence; 
        }
    }
}
