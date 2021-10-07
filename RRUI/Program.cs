using System;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("Welcome to the restaurant review system");
            bool go = true;
            //example of polymorthism, abstraction and inharitence 
            IMenu page = new MainMenu();

            while (go)
            {
                Console.Clear();
                page.Menu();
                MenuType currentPage = page.YourChoice();

                Console.WriteLine(@String.Join(Environment.NewLine,
                "Please choose an option",
                "   [0] To exit the system",
                "   [1] To clear the screen",
                "   [2] To leave a review"));
                string input = Console.ReadLine();

                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        page= new MainMenu();
                        break;

                    case MenuType.RestaurantMenu:
                       page=  new RestaurantMenu();
                        break;

                    case MenuType.Exit:
                        Console.WriteLine("You are exiting the application");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        go=false;
                        break;

                    default:
                        Console.WriteLine("you forgot to add a menue in your enum");
                        go=false;
                        break;
                }
                //go=false;
            }
        }
    }
}
