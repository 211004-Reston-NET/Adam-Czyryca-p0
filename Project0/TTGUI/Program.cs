using System;
using TTGBL;
using TTGDL;

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
                    case MenuType.TestingMenu:
                        page = new TestingMenu();
                        break;
                    case MenuType.LogInMenu:
                        page = new LogInMenu(new LogInBL(new CustRepository()));
                        break;
                    case MenuType.CurrentCustomer:
                        page = new CurrentCustomer(new CustomerBL(new CustRepository()));
                        break;
                    case MenuType.ShowCustomers:
                        page = new ShowCustomers(new CustomerBL(new CustRepository()));
                        break;
                    case MenuType.ShowStores:
                        page = new ShowStores(new StoreBL(new StoreRepository()));
                        break;
                    case MenuType.ShowProducts:
                        page = new ShowProducts(new ProductBL(new ProductRepo()));
                        break;
                    case MenuType.AddCustomerMenu:
                        page = new AddCustomerMenu(new CustomerBL(new CustRepository()));
                        break;
                    case MenuType.AddStoreMenu:
                        page = new AddStoreMenu(new StoreBL(new StoreRepository()));
                        break;
                    case MenuType.AddProductsMenu:
                        page = new AddProductsMenu(new ProductBL(new ProductRepo()));
                        break;
                    case MenuType.AddLineItemsMenu:
                        page = new AddLineItemsMenu(new LineItemBL(new LineItemRepo()));
                        break;
                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuType.StoreMenu:
                        page = new StoreMenu();
                        break;
                    case MenuType.CustomerMenu:
                        page = new CustomerMenu();
                        break;
                    case MenuType.LineItemMenu:
                        page = new LineItemMenu();
                        break;
                    case MenuType.ProductMenu:
                        page = new ProductMenu();
                        break;
                    case MenuType.OrdersMenu:
                        page = new OrdersMenu();
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("You are exiting the application");
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
