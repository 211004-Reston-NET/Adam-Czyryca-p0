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
            "[1] Place order",
            "[2] View current orders",
            "[0] Go back to logIn",
            "______________________________________"

            )); 
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                
                case "1":
                    return MenuType.AddOrderMenu;
                case "2":
                    return MenuType.ShowOrders;
                case "3":
                    return MenuType.OrdersMenu;
                case "4":
                    return MenuType.OrdersMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.OrdersMenu;
            }
        }
    }
}