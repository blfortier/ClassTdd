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
            Dictionary<string, List<string>> dictionaryWithIngredientsandTheirDishes = new Dictionary<string, List<string>>();

                for (int row = 0; row < dishes.Length; row++)
                {
                    string dish = dishes[row][0];

                    for (int col = 1; col < dishes[row].Length; col++)
                    {
                        string ingredient = dishes[row][col];

                        if (!dictionaryWithIngredientsandTheirDishes.ContainsKey(ingredient))
                        dictionaryWithIngredientsandTheirDishes.Add(ingredient, new List<string>());

                        dictionaryWithIngredientsandTheirDishes[ingredient].Add(dish);
                    }
                }

                return dictionaryWithIngredientsandTheirDishes;
        }

        public List<string> GetListOfIngredientsThatArePresentIn2orMoreDishes(Dictionary<string, List<string>> IngredientsAndTheirDishes)
        {
            List<string> ingredientsWithAtLeast2Dishes = new List<string>();

            foreach (string ingredient in IngredientsAndTheirDishes.Keys)
                if (IngredientsAndTheirDishes[ingredient].Count >= 2)
                {
                    ingredientsWithAtLeast2Dishes.Add(ingredient);
                }

            return ingredientsWithAtLeast2Dishes;
        }

    }

}
