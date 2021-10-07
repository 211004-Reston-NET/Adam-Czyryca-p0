using System;

namespace RRUI
{
    // the ":" is used to indicate that u inharit another 
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu");
            Console.WriteLine("What do you want to do");
            Console.WriteLine("[1] - Go to Resturaunt");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string usrChoice= Console.ReadLine();

            switch (usrChoice)
            {
                case "1":
                    return MenuType.RestaurantMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}