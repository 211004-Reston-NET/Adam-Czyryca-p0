using System;
namespace TTGUI 
{
    public class ProductMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(String.Join(Environment.NewLine,
            "____________________________________",
            "Welcome to the Product information page",
            "What would you like to do?",
            "[1] View product names",
            "[2] View product price",
            "[3] View project description",
            "[4] View project category",
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
                 return MenuType.ProductMenu;
                case "3":
                 return MenuType.ProductMenu;;
                case "2":
                 return MenuType.ProductMenu;;
                case "1":
                 return MenuType.ProductMenu;;
                case "0": 
                 return MenuType.MainMenu;
                default:
                 Console.WriteLine(" Enter a Valid option ");
                 return MenuType.ProductMenu;;
            }
        }
    }
}