using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class CurrentProduct : IMenu
    {
        private IProductBL _custBL;

        public CurrentProduct(IProductBL p_custBL)
        {
            _custBL=p_custBL;
        }
        public void Menu()
        {
            List<Product> ListOfProducts = _custBL.GetProduct(ShowProducts._findProdName);

            Console.WriteLine("This is the search result");
            foreach (Product Product in ListOfProducts)
            {
                Console.WriteLine(
                    "-------------------------\n"+
                    $"{Product}\n"+
                    "-------------------------\n"
                ); 
            }
            Console.WriteLine("[0] - Go back");
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.ProductMenu;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    return MenuType.CurrentProduct;
            }
        }
    }
}