using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Console
{
    //Create a Menu Class with properties, constructors, and fields.


    public class Menu
    {
        public string MealName { get; set; }

        public string MealDescription { get; set; }

        public List<string> Ingredients { get; set; }

        public decimal Price { get; set; }

        public int MealNumber { get; set; }


        public Menu(string mealName, string mealDescription, decimal price, List<string> ingredients, int mealNumber)
        {
            MealName = mealName;
            MealDescription = mealDescription;
            Price = price;
            Ingredients = ingredients;
            MealNumber = mealNumber;
        }

        public Menu()
        {

        }
    }
}
