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

            while (go)
            {
                Console.Clear();
                Console.WriteLine(@String.Join(Environment.NewLine,
                "Please choose an option",
                "   [0] To exit the system",
                "   [1] To clear the screen",
                "   [2] To leave a review"));
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Good bye");
                        go=false;
                        break;

                    case "1":
                        Console.WriteLine("The user chose to clear the screen");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("This feature is still under development");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                        
                    default:
                        break;
                }
                //go=false;
            }
        }
    }
}
