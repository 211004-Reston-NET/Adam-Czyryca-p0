
using System;

namespace TTGUI
{
    public class CustomerMenu : IMenu
    {
        public void Menu()
        {
           Console.WriteLine(
            "_______________________________________________\n"+
            "Welcome to the Customer information page\n"+
            "What would you like to do?\n"+
            "[3] Show all Customers\n"+
            "[2] Add new customer\n"+
            "[1] View your orders\n"+
            "[0] Go back to main Menu\n"+
            "_______________________________________________\n");


             
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "3":
                    return MenuType.CustomerMenu;
                case "2":
                    return MenuType.AddCustomerMenu;
                case "1":
                 return MenuType.CustomerMenu;
                case "0": 
                 return MenuType.MainMenu;
                default:
                 Console.WriteLine(" Enter a Valid option ");
                 return MenuType.CustomerMenu;
            }
        }
    }
}