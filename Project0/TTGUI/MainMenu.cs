using System;

namespace TTGUI
{

    public class MainMenu : IMenu
    {
        public void Menu()
        {
          
            Console.WriteLine(
            "______________________________\n"+
            "Welcome to the main Menu\n"+
            "Where do you want to go?\n"+
            "[1] store Menu\n"+
            "[2] Customer Menu\n"+
            "[3] Orders Menu\n"+
            "[4] Products Menu\n"+
            "[5] LineItem Menu\n"+
            "[0] Exit\n"+
            "______________________________");
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