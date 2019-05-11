using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProblem
{
    public class SequenceLauncher
    {
        public bool LaunchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {
            for (int i = 0; i < stepNumbers.Length; i++)
            {
                List<string> systemNamesList = new List<string>();
                if (stepNumbers[i] > stepNumbers[i + 1])
                    return false;
              
            }

            return true;
        }
    }  
}
