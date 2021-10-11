using System;

namespace TTGUI
{

    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(String.Join(Environment.NewLine,
            "______________________________",
            "Welcome to the main Menu",
            "Where do you want to go?",
            "[1] store Menu",
            "[2] Customer Menu",
            "[3] Orders Menu",
            "[4] Products Menu",
            "[5] LineItem Menu",
            "[0] Exit",
            "______________________________"
           
            ));
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "5":
                 return MenuType.LineItemMenu;
                case "4":
                    return MenuType.ProductMenu;
                case "3":
                    return MenuType.OrdersMenu;
                case "2":
                 return MenuType.CustomerMenu;
                case "1":
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.MainMenu;
            }
        }
    }
}