using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackWeight
{
    public class Knapsack
    {
        public static int TreasureChecker(int weight1, int value1, int weight2, int value2, int maxWeight)
        {
            int heaviestItem = Math.Max(weight1, weight2);
            int combinedWeightOfBothItems = weight1 + weight2;
            Console.WriteLine("heaviest item weight: {0}", heaviestItem);

            // combinedWeightOfBothItems < maxWeight && (maxWeight - (combinedWeightOfBothItems) < weight1 || maxWeight - (combinedWeightOfBothItems) < weight2)

            /*
             
            item 1 weight = 4   value 8
            item 2 weight = 7   value 13
            max weight = 7      return 13

            item1 w = 5  value = 8
            item2 w = 4  value = 4
            max w = 9

            value1 = 15;
            weight1 = 2;
            value2 = 20;
            weight2 = 3;
            maxWeight = 2;

            value1 = 15;
            weight1 = 7;
            value2 = 20;
            weight2 = 6;
            maxWeight = 6
             */

            //if (maxWeight < weight1 && maxWeight < weight2)
            //    return 0;

            if (maxWeight < weight1 && maxWeight < weight2)
                return 0;
            if (maxWeight < weight1 && weight2 >= maxWeight)
                return value2;
            if (maxWeight < weight2 && weight1 >= maxWeight)
                return value1;
            if (combinedWeightOfBothItems == maxWeight)
                return value1 + value2;
            if (maxWeight >= weight1 || maxWeight >= weight2 && combinedWeightOfBothItems < maxWeight)
                return ((value1 > value2) ? value1 : value2);

            throw new ArgumentException();
        }
    }
}
