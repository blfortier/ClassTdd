using System;

namespace LotteryService
{
    public class Class1
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            if (lotteryNums.Length > 1)
            {
                bool flag = true;

                for (var i = 0; i < lotteryNums.Length - 1 && flag; i++)
                {
                    flag = false;
                    for (var j = 0; j < lotteryNums.Length - 1; j++)
                    {
                        if (lotteryNums[j] > lotteryNums[j + 1])
                        {
                            var temp = lotteryNums[j];
                            lotteryNums[j] = lotteryNums[j + 1];
                            lotteryNums[j + 1] = temp;
                            flag = true;
                        }
                    }
                }
            }
            return lotteryNums;
        }
    }
}
