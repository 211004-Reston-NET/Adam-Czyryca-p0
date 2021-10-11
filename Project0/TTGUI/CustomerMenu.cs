
using System;

namespace TTGUI
{
    public class CustomerMenu : IMenu
    {
        public void Menu()
        {
           Console.WriteLine(String.Join(Environment.NewLine,
            "____________________________________",
            "Welcome to the Customer information page",
            "What would you like to do?",
            "[0] Edit customer information",
            "[1] View your orders",
            "[2] Go back to main Menu",
            "______________________________________"

            )); 
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                 return MenuType.CustomerMenu;
                case "1":
                 return MenuType.CustomerMenu;
                case "2": 
                 return MenuType.MainMenu;
                default:
                 Console.WriteLine(" Enter a Valid option ");
                 return MenuType.CustomerMenu;
            }
        }
    }
}