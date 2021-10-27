using TTGBL;
using TTGDL;

namespace TTGUI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
           switch (p_menu)
           {
                case MenuType.TestingMenu:
                    return new TestingMenu();
                case MenuType.LogInMenu:
                    return new LogInMenu(new LogInBL(new CustRepository()));
                case MenuType.CurrentCustomer:
                    return new CurrentCustomer(new CustomerBL(new CustRepository()));
                case MenuType.ShowCustomers:
                    return new ShowCustomers(new CustomerBL(new CustRepository()));
                case MenuType.ShowStores:
                    return new ShowStores(new StoreBL(new StoreRepository()));
                case MenuType.ShowProducts:
                    return new ShowProducts(new ProductBL(new ProductRepo()));
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new CustomerBL(new CustRepository()));
                case MenuType.AddStoreMenu:
                    return new AddStoreMenu(new StoreBL(new StoreRepository()));
                case MenuType.AddProductsMenu:
                    return new AddProductsMenu(new ProductBL(new ProductRepo()));
                //case MenuType.AddLineItemsMenu:
                //    return new AddLineItemsMenu(new LineItemBL(new LineItemRepo()));
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.LineItemMenu:
                    return new LineItemMenu();
                case MenuType.ProductMenu:
                    return new ProductMenu();
                case MenuType.OrdersMenu:
                    return new OrdersMenu();
                default:
                    return null;

           }
        }
    }
}