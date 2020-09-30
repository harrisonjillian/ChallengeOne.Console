using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Console
{
    class ProgramUI
    {
        private MenuRepository _menuRepository = new MenuRepository();  

        public void Run()
        {
            SeedMenuItems();
            Menu();
            
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning) 
            {
                Console.WriteLine("Choose a selection: \n" +
                    "1. Add Menu Items to Menu List \n" +
                    "2. Delete Menu Items \n" +
                    "3. View All Menu Items \n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddMenuItemstoList();
                        break;
                    case "2":
                        DeleteMenuItemsFromList();
                        break;
                    case "3":
                        ViewAllMenuItems();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number (1 - 4)");

                        break;
                }

                Console.ReadKey();
                Console.Clear();



            }
        }

        //Add Menus to List
        private void AddMenuItemstoList()
        {
            Console.Clear();
            Menu newMenuItem = new Menu();

            //MealName
            Console.WriteLine("Enter the meal name:");
            newMenuItem.MealName = Console.ReadLine();

            //Meal Description
            Console.WriteLine("Enter the meal description:");
            newMenuItem.MealDescription = Console.ReadLine();

            //Price
            Console.WriteLine("Enter the meal price:");
            string mealPriceAsString = Console.ReadLine();
            newMenuItem.Price = decimal.Parse(mealPriceAsString);


            //Ingredient List - come back to this.
            Console.WriteLine("Enter the ingredient list:");


            string ingredientInput = Console.ReadLine();

            List<Menu> listOfIngredients = new List<Menu>();
            foreach (Menu item in listOfIngredients)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter the meal number:");
            string mealNumberAsString =  Console.ReadLine();
            newMenuItem.MealNumber = int.Parse(mealNumberAsString);

            _menuRepository.CreateNewMenuItems(newMenuItem);
        }

        private void DeleteMenuItemsFromList()
        {
            Console.Clear();
            ViewAllMenuItems();

            Console.WriteLine("Enter the name of the meal you would like removed:");
            string mealName = Console.ReadLine();

            bool wasDeleted = _menuRepository.RemoveMenuItemsFromInventory(mealName);

            if (wasDeleted)
            {
                Console.WriteLine("The meal was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The meal was not able to be deleted.");
            }

           

        }

        private void ViewAllMenuItems()
        {
            Console.Clear();
            List<Menu> _menuItems = _menuRepository.ViewMenuItems();

            foreach(Menu menu in _menuItems)
            {
                Console.WriteLine($"Menu Name: {menu.MealName} \n" +
                    $"Menu Description: {menu.MealDescription}");
            }
        }

        private void SeedMenuItems()
        {
            Menu PretzelBaconHamburger = new Menu("Pretzel Bacon Hamburger", "Deliciously fresh quarter pounder with all the right toppings", 5.50m, new List<String> {"beef", "cheese sauce", "bacon", "honey mustard\n" +
                "fried onions", "pickles"}, 1);

            Menu DoubleStackHamburger = new Menu("Double Stack Burger", "Two beef patties stacked with all the toppings", 5.00m, new List<String> { "beef", "cheese", "ketchup", "mustard", "pickles", "tomatoes\n" +
                "onion"}, 2);

            Menu GrilledChickenSandwich = new Menu("Grilled Chicken Sandwich", "Herb Roasted Chicken Sandwich", 5.75m, new List<string> { "chicken", "mustard", "spring mix", "tomato" }, 3);

            _menuRepository.CreateNewMenuItems(PretzelBaconHamburger);
            _menuRepository.CreateNewMenuItems(DoubleStackHamburger);
            _menuRepository.CreateNewMenuItems(GrilledChickenSandwich);
        }
       
    }
}

