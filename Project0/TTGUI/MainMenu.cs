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
            "[0] Exit",
            "______________________________"
           
            ));
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "2":
                 return MenuType.CustomerMenu;
                case "1":
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    return MenuType.MainMenu;
            }
        }
    }
}