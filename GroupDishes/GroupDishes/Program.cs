using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDishes
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupingDishes dish = new GroupingDishes();

            string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            //    dish.AddIngredientsAndCountsToDictionary(dishes);
            //  dish.AddIngredientsAndListOfDishesToDictionary(dishes);

            //foreach (var item in dish.AddIngredientsAndCountsToDictionary(dishes))
            //{
            //    Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            //}

            var test = dish.AddIngredientsAndListOfDishesToDictionary(dishes);

            Console.WriteLine(test.Count);
            foreach (var item in test)
            {
                Console.WriteLine("hi");
                Console.WriteLine("key: {0}", item.Key);

                foreach (var t in test.Values)
                {
                    Console.WriteLine("values: {0}", t);
                }
            }

        }
    }
}
