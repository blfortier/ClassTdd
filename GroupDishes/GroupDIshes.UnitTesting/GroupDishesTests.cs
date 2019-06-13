using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDishes;

namespace GroupDIshes.UnitTesting
{
    [TestFixture]
    public class GroupDishesTests
    {
        GroupingDishes dishesToMake = new GroupingDishes();

        [Test]
        public void ForTwoDishesWithWithOneIngredientEach_AddToDictionary_ReturnDictionary()
        {
            string[][] dishes = {
                new string[] { "Salad", "Tomato" },
                new string[] { "Pizza", "Tomato" }
            };

            Dictionary<string, int> ingredients = new Dictionary<string, int>()
            { 
                { "Tomato", 2 }
            };

            foreach (var item in ingredients)
                Console.WriteLine("k: {0}, v: {1}", item.Key, item.Value);

            Dictionary<string, int> expected = ingredients;
            var actual = dishesToMake.AddIngredientsAndCountsToDictionary(dishes);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ForFourDishesWithFourIngredientEach_AddToDictionary_ReturnDictionary()
        {
            string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            Dictionary<string, int> ingredients = new Dictionary<string, int>()
            {
                { "Bread", 1},
                { "Cheese", 2 },
                { "Chicken", 1},
                { "Cucumber", 1 },
                { "Dough", 1},
                { "Salad", 2 },
                { "Sauce", 3 },
                { "Sausage", 1},
                { "Tomato", 3 }
            };

            foreach (var item in ingredients)
                Console.WriteLine("k: {0}, v: {1}", item.Key, item.Value);

            Dictionary<string, int> expected = ingredients;
            var actual = dishesToMake.AddIngredientsAndCountsToDictionary(dishes);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ForFourDishesWithFourIngredientEach_AddIngredientsAsKeysAndListOfDishesToDictionary_ReturnDictionary()
        {
            string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            Dictionary<string, List<string>> ingredients = new Dictionary<string, List<string>>();

            ingredients.Add("Bread", new List<string> { "Sandwich" });
            ingredients.Add("Cheese", new List<string> { "Quesadilla", "Sandwich" });
            ingredients.Add("Chicken", new List<string> { "Quesadilla" });
            ingredients.Add("Cucumber", new List<string> { "Salad" });
            ingredients.Add("Dough", new List<string> { "Pizza" });
            ingredients.Add("Salad", new List<string> { "Salad", "Sandwich" });
            ingredients.Add("Sauce", new List<string> { "Salad", "Pizza", "Quesadilla" });
            ingredients.Add("Sausage", new List<string> { "Pizza" });
            ingredients.Add("Tomato", new List<string> { "Salad", "Pizza", "Sandwich" });
         
            foreach (KeyValuePair<string, List<string>> item in ingredients)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Dictionary<string, List<string>> expected = ingredients;
            var actual = dishesToMake.AddIngredientsAndListOfDishesToDictionary(dishes);

            Assert.AreEqual(expected, actual);
        }



    }
}

/*
  dishes = [["Salad", "Tomato", "Cucumber", "Salad", "Sauce"],
            ["Pizza", "Tomato", "Sausage", "Sauce", "Dough"],
            ["Quesadilla", "Chicken", "Cheese", "Sauce"],
            ["Sandwich", "Salad", "Bread", "Tomato", "Cheese"]]
            
output:
  groupingDishes(dishes) = [["Cheese", "Quesadilla", "Sandwich"],
                            ["Salad", "Salad", "Sandwich"],
                            ["Sauce", "Pizza", "Quesadilla", "Salad"],
                            ["Tomato", "Pizza", "Salad", "Sandwich"]]  




    dishes = [["Pasta", "Tomato Sauce", "Onions", "Garlic"],
        ["Chicken Curry", "Chicken", "Curry Sauce"],
        ["Fried Rice", "Rice", "Onions", "Nuts"],
        ["Salad", "Spinach", "Nuts"],
        ["Sandwich", "Cheese", "Bread"],
        ["Quesadilla", "Chicken", "Cheese"]]

    groupingDishes(dishes) = [["Cheese", "Quesadilla", "Sandwich"],
                            ["Chicken", "Chicken Curry", "Quesadilla"],
                            ["Nuts", "Fried Rice", "Salad"],
                            ["Onions", "Fried Rice", "Pasta"]]
*/

