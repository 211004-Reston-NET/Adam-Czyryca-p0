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
                //replace with checkoutMenu when chechoutMenu is made
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