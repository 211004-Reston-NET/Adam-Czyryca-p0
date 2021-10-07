using System;

namespace TTGUI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(String.Join(Environment.NewLine,
            "____________________________________",
            "Welcome to the Table Top Game Store",
            "What would you like to do?",
            "[0] Checkout",
            "[1] Place an order",
            "[2] Go back to main Menu",
            "______________________________________"

            ));
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                //replace with checkoutMenu when chechoutMenu is made
                case "0":
                    return MenuType.StoreMenu;
                case "1":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.MainMenu;
                default:
                    return MenuType.StoreMenu;
            }
        }
    }
}