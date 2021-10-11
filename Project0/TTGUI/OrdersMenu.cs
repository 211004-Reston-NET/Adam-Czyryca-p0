using System;
namespace TTGUI
{
    public class OrdersMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(String.Join(Environment.NewLine,
            "____________________________________",
            "Welcome to the Order page",
            "What would you like to do?",
            "[1] View items in your order",
            "[2] View Store purchase location",
            "[3] View Total Price",
            "[0] Go back to main Menu",
            "______________________________________"

            )); 
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "3":
                    return MenuType.StoreMenu;
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