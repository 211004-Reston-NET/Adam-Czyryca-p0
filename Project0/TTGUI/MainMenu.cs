using System;

namespace TTGUI
{

    public class MainMenu : IMenu
    {
        public void Menu()
        {
          
            Console.WriteLine(
            "___________________________\n"+
            "[1] - LogIn\n"+
            "[2] - New Customer\n"+
            "[0] - Exit\n"+
            "____________________________"
            );
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
               
                case "2":
                    return MenuType.AddCustomerMenu;
                case "1":
                    return MenuType.LogInMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.MainMenu;
            }
        }
    }
}