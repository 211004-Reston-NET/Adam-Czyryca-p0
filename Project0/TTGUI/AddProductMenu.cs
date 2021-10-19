using System;
using TTGModel;
using TTGBL;
namespace TTGUI
{
    public class AddProductsMenu : IMenu
    {
        
        private static Products _products = new Products();
        private IProductBL _productsBL;

        public AddProductsMenu(IProductBL p_productsBL)
        {
            _productsBL = p_productsBL;
        }
        public void Menu()
        {
            
            Console.WriteLine("______________________________");
            Console.WriteLine("Adding a new Products");
            Console.WriteLine("Name - " + _products.Name);
            Console.WriteLine("Price - "+ _products.Price);
            Console.WriteLine("[1] - Input value for Name");
            Console.WriteLine("[2] - Input value for Price");
            Console.WriteLine("[3] - Add Products");
            Console.WriteLine("[0] - Go Back");
            Console.WriteLine("______________________________"); 
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "3":
                    _productsBL.AddProduct(_products);
                    Console.WriteLine("Products has been added successfully");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    _products.Name="";
                    //_products.Price="";
                    return MenuType.AddProductsMenu;
                case "2":
                    Console.Write("Price: ");
                    _products.Price= Convert.ToDouble(Console.ReadLine());
                    
                    return MenuType.AddProductsMenu;
                case "1":
                    Console.Write("Name: ");
                    _products.Name= Console.ReadLine();
                    return MenuType.AddProductsMenu;
                case "0": 
                    return MenuType.ProductMenu;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.CustomerMenu;
            }
        }
    }
}