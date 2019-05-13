using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];
            else if (arr.Length == 2)
                return (arr[0] < arr[1]) ? arr[0] : arr[1];
            else if (arr.Length >= 3)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < max)
                        max = arr[i];
                }
                return max;
            }
            else
                throw new ArgumentException();
        }

        public int FindClosestIntToZero(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException();
            else if (arr.Length == 1)
                return 1;
            else if (arr.Length == 2)
                return (arr[0] < arr[1]) ? arr[0] : arr[1];
            else 
            {
                int closestToZero = arr[0];
                
                for (int i = 1; i < arr.Length; i ++)
                {
                    if (Math.Abs(arr[i]) < Math.Abs(closestToZero))
                        closestToZero = arr[i];
                    if ((Math.Abs(arr[i]) == Math.Abs(closestToZero)) && (arr[i] < closestToZero))
                        closestToZero = arr[i];
                }
                return closestToZero;
            }
        }
    }
}
