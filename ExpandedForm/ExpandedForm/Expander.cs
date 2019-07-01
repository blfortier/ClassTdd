using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandedForm
{
    public class Expander
    {
        public static string ExpandNumber(long number)
        {
            string numberStr = number.ToString();

            StringBuilder expandedForm = new StringBuilder();
            int numberOfZeros = numberStr.Length - 1;
            
            for (int index = 0; index < numberStr.Length - 1; index++)
            {
                if (numberStr[index] == '0')
                    continue;
                if (index != numberStr.Length - 1)
                    expandedForm.Append(numberStr[index]).Append('0', numberOfZeros - index).Append(" + ");
                   
                Console.WriteLine("{0}", expandedForm.ToString());
            }

            if (numberStr[numberStr.Length - 1] != '0')
                expandedForm.Append(numberStr[numberStr.Length - 1]);
            else
            {
                for (int lengthOfExtraSpace = 0; lengthOfExtraSpace <= 2; lengthOfExtraSpace++)
                    expandedForm.Length--;
            }
            
            return expandedForm.ToString();
        }
    }
}
