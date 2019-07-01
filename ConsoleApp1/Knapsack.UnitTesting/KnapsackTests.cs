using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack.UnitTesting
{
    [TestFixture]
    public class KnapsackTests
    {
        int weight1, weight2, value1, value2, maxWeight;

        [Test]
        public void IfOnlyOneItemCanBePicked_AndItem1AndItem2AreBothOptions_ChooseTheItemWithAHigherValue()
        {
            weight1 = 7;
            value1 = 8;
            weight2 = 6;
            value2 = 13;
            maxWeight = 10;

            int expected = 13;
            int actual = KnapsackWeight.Knapsack.TreasureChecker(weight1, value1, weight2, value2, maxWeight);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfBothItemsWeightEqualsMaxWeight_ReturnTotalOfBothValues()
        {
            weight1 = 5;
            value1 = 8;
            weight2 = 4;
            value2 = 4;
            maxWeight = 9;

            int expected = 12;
            int actual = KnapsackWeight.Knapsack.TreasureChecker(weight1, value1, weight2, value2, maxWeight);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfOneItemWeighsMoreThanMaxWeight_AndMaxWeightIsGreaterThanOrEqualToOtherItem_ReturnOtherItem()
        {
            value1 = 15;
            weight1 = 2;
            value2 = 20;
            weight2 = 3;
            maxWeight = 2;

            int expected = 15;
            int actual = KnapsackWeight.Knapsack.TreasureChecker(weight1, value1, weight2, value2, maxWeight);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IfMaxWeightIsLessThanBothOfTheItems_Return0()
        {
            value1 = 15;
            weight1 = 2;
            value2 = 20;
            weight2 = 3;
            maxWeight = 1;

            int expected = 0;
            int actual = KnapsackWeight.Knapsack.TreasureChecker(weight1, value1, weight2, value2, maxWeight);

            Assert.AreEqual(expected, actual);
        }



    }
}
