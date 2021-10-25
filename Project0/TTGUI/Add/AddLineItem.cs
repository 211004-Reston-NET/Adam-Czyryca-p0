using System;
using TTGModel;
using TTGBL;
namespace TTGUI
{
    public class AddLineItemsMenu : IMenu
    {

        private static LineItems _LineItem = new LineItems();
        private static Product _prod = new Product();
        private ILineItemBL _LineItemsBL;

        public AddLineItemsMenu(ILineItemBL p_LineItemsBL)
        {
            _LineItemsBL = p_LineItemsBL;
        }
        public void Menu()
        {

            Console.WriteLine("______________________________");
            Console.WriteLine("Adding a new LineItems");
            Console.WriteLine("Product - " + SingletonProduct.product.Name);
            Console.WriteLine("Quantity - " + _LineItem.Quantity);
            Console.WriteLine("[1] - Input value for product");
            Console.WriteLine("[2] - Input value for Quantity");
            Console.WriteLine("[3] - Add LineItems");
            Console.WriteLine("[0] - Go Back");
            Console.WriteLine("______________________________");
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "3":
                    _LineItem.Product = SingletonProduct.product;
                    _LineItemsBL.AddLineItem(_LineItem);
                    Console.WriteLine("LineItems has been added successfully");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    //_LineItems.Product="";
                    //_LineItems.Quantity="";
                    return MenuType.AddLineItemsMenu;
                case "2":
                    Console.Write("Quantity: ");
                    _LineItem.Quantity = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddLineItemsMenu;
                case "1":
                    Console.Write("Product Name: ");
                    SingletonProduct.product.Name = Console.ReadLine();

                    //_LineItems.Product= Singleton.Products;
                    return MenuType.AddLineItemsMenu;
                case "0":
                    return MenuType.LineItemMenu;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.CustomerMenu;
            }
        }
    }
}