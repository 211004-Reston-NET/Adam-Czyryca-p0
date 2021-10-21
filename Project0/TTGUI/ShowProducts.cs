using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class ShowProducts : IMenu
    {
        public IProductBL _prodBL;//IprodBL
        public static string _findProdName;
        public ShowProducts(IProductBL p_prodBL)//IprodBL
        {
            _prodBL=p_prodBL;
        }

        public void Menu()
        {
            Console.WriteLine("ShowProducts in Database");
            List<Products> ListOfProducts = _prodBL.GetAllProducts();

            foreach (Products product in ListOfProducts)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(product);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("[1] - search for product");
            Console.WriteLine("[0] - Go back");
            
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter a name for the product you want to find");
                    _findProdName = Console.ReadLine();
                    return MenuType.CurrentProduct;
                case "0":
                    return MenuType.ProductMenu;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    return MenuType.ShowProducts;
            }
        }
    }
}