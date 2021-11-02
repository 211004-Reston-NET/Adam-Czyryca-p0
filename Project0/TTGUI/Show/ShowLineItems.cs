using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class ShowLineItems : IMenu
    {
        private ILineItemBL _lineItemBL;
        public static string _findlineItemName;
        public ShowLineItems(ILineItemBL p_lineItemBL)
        {
            _lineItemBL = p_lineItemBL;
        }
        public void Menu()
        {
            Console.WriteLine("Registered LineItem");
            List<LineItem> ListOfLineItem = _lineItemBL.GetAllLineItems();
            foreach (LineItem LineItem in ListOfLineItem)
            {
                Console.WriteLine(
                    "-------------------------\n" +
                    $"{LineItem}\n" +
                    "-------------------------\n"
                );
            }
            Console.WriteLine("[1] - search for LineItem");
            Console.WriteLine("[0] - Go back");
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter a name for the LineItem you want to find");
                    _findlineItemName = Console.ReadLine();
                    return MenuType.ShowLineItems;
                case "0":
                    return MenuType.LineItemMenu;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    return MenuType.ShowLineItems;
            }
        }
    }
}