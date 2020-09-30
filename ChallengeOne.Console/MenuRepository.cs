using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Console
{
    public class MenuRepository
    {
        public List<Menu> _menuItems = new List<Menu>();

        //Create Menu Items
        public void CreateNewMenuItems (Menu menu)
        {
            _menuItems.Add(menu);
        }

        //Read & View (Receive the list of all items on the cafe menu)

        public List<Menu> ViewMenuItems()
        {
            return _menuItems;
        }

        //Delete Menu Items

        public bool RemoveMenuItemsFromInventory(string mealName)
        {
            Menu menu = GetMenuFromList(mealName); 
            if (menu == null)
            {
                return false;
            }

            _menuItems.Remove(menu);
            return true;
        }

        //Helper

        public Menu GetMenuFromList(string mealName)
        {
            foreach (Menu menu in _menuItems)
            {
                if (menu.MealName == mealName)
                {
                    return menu;
                }
            }
            return null;
           
        }


    }
}
