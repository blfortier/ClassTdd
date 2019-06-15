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

            dish.AddIngredientsAndCountsToDictionary(dishes);
            dish.AddIngredientsAndListOfDishesToDictionary(dishes);


        }
    }
}
