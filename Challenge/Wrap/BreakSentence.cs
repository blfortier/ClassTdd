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
            if (sentence.Length == 0 || columnNumber == sentence.Length)
                return sentence;

            int counter = 0;

            StringBuilder sb = new StringBuilder();

            foreach (var c in sentence)
            {
                if (c != '\n')
                    counter++;

                sb.Append(c);
                if ((counter % columnNumber) == 0)
                    sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
