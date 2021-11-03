using System;
namespace TTGUI
{
    public class OrdersMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(
            "------------------------------\n" +
            $"Current User: {SingletonCustomer.Customer.Name}\n" +
            "------------------------------\n" +
            "____________________________________",
            "Welcome to the Order page\n" +
            "What would you like to do?\n" +
            "[1] Place order\n" +
            "[2] View current orders\n" +
            "[0] Go back\n" +
            "______________________________________"

            );
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
                    if (SingletonUser.User == 0)
                    {
                        return MenuType.CustomerMenu;
                    }
                    else
                    {
                        return MenuType.TestingMenu;
                    }
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.OrdersMenu;
            }
        }
    }
}