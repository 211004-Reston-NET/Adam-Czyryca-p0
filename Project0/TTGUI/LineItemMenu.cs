using System;
namespace TTGUI
{
    public class LineItemMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine(String.Join(Environment.NewLine,
            "___________________________________________",
            "Welcome to the LineItem information page",
            "What would you like to do?",
            "[1] view product quantity",
            "[2] Edit product quantity",
            "[0] Go back to main Menu",
            "___________________________________________"
            )); 
        }

        public MenuType Navigation()
        {
            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "2":
                 return MenuType.LineItemMenu;
                case "1":
                 return MenuType.LineItemMenu;
                case "0":
                 return MenuType.MainMenu;
                default:
                 Console.WriteLine(" Enter a Valid option ");
                 return MenuType.LineItemMenu;
            }
        }
    }
}