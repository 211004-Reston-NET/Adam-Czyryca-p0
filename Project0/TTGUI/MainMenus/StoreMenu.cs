using System;

namespace TTGUI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(String.Join(Environment.NewLine,
            "____________________________________",
            "Welcome to the store page",
            "What would you like to do?",
            "[1] Show Store list",
            "[2] Add a store",
            "[0] Go back to main Menu",
            "______________________________________"

            ));
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                // case "4":
                //     return MenuType.ShowStores;
                // case "3":
                //     return MenuType.AddStoreMenu;
                case "2":
                    return MenuType.AddStoreMenu;
                case "1":
                    return MenuType.ShowStores;
                case "0":
                    //return MenuType.MainMenu;
                    return MenuType.TestingMenu;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.StoreMenu;
            }
        }
    }
}