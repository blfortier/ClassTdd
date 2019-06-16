using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDishes
{
    public class GroupingDishes
    {
        Dictionary<string, int> ingredientCount = new Dictionary<string, int>();

        public string[][] GroupDishes(string[][] dishes)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> AddIngredientsAndCountsToDictionary(string[][] dishes)
        {
            for (int row = 0; row < dishes.Length; row++)
            {
                for (int col = 1; col < dishes[row].Length; col++)
                {
                    if (ingredientCount.ContainsKey(dishes[row][col]))
                        ingredientCount[dishes[row][col]]++;
                    else
                        ingredientCount.Add(dishes[row][col], 1);
                }
            }

            return ingredientCount;
        }
        
        public Dictionary<string, List<string>> AddIngredientsAndListOfDishesToDictionary(string[][] dishes)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            /*
             * string[][] dishes = {
                new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" },
                new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };
             * 
             */


            for (int row = 0; row < dishes.Length; row++)
            {
                string dish = dishes[row][0];

                for (int col = 1; col < dishes[row].Length; col++)
                {
                    string ingredient = dishes[row][col];

                    if (!result.ContainsKey(ingredient))
                        result.Add(ingredient, new List<string>());

                    result[ingredient].Add(dish);
                    //IngredientsAndTheirDishes[dishes[row][col]].Add(dishes[row][0]);
                }
            }

            return result;




            //foreach (var item in ingredientCount)
            //{
            //    if (item.Value >= 2)
            //    {
            //        List<string> dishesToAdd;

            //        for (int row = 0; row < dishes.Length; row++)
            //        {
            //            for (int col = 1; col < dishes[row].Length; col++)
            //            {
            //                dishesToAdd = new List<string>();

            //                if (dishes[row][col] == item.Key)
            //                {

            //                    dishesToAdd.Add(dishes[row][0]);

            //                }
            //                result.Add(item.Key, dishesToAdd);

            //            }
            //        }
            //        // result.Add();
            //    }
            //}

        }

    }

}
