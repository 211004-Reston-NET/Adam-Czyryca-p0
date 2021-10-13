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
            "[4] Show Store list",
            "[3] Add a store",
            "[1] Checkout",
            "[2] Place an order",
            "[0] Go back to main Menu",
            "______________________________________"

            ));
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "4":
                    return MenuType.ShowStores;
                case "3":
                    return MenuType.AddStoreMenu;
                case "2":
                    return MenuType.StoreMenu;
                case "1":
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.StoreMenu;
            }
        }
    }
}