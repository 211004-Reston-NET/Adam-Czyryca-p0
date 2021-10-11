using System;

namespace TTGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            IMenu page = new MainMenu();

            while (repeat)
            {
                Console.Clear();
                page.Menu();
                MenuType currentPage = page.Navigation();

                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        page= new MainMenu(); 
                        break;
                    case MenuType.StoreMenu:
                        page= new StoreMenu();
                        break;
                    case MenuType.CustomerMenu:
                        page= new CustomerMenu();
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("You are exiting the application");
                        Console.WriteLine("Press enter to continue...");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("enter the requiered menu into enum in IMenu");
                        repeat = false;
                        break;
                }      
            }
        }
    }
}
