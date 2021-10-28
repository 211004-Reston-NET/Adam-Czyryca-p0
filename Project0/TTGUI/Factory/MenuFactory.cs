using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTGBL;
using TTGDL;
using TTGDL.Entities;

namespace TTGUI
{
    public class MenuFactory : IFactory
    {

        public IMenu GetMenu(MenuType p_menu)
        {
            var config = new ConfigurationBuilder()//ConfigurationBuilder id class from Microsoft.extentions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory())//gets directory of TTGUI file path
                .AddJsonFile("appsetting.json")//adds appsetting.json from TTGUI
                .Build();//builds configuration

            DbContextOptions<database1Context> options = new DbContextOptionsBuilder<database1Context>()
                .UseSqlServer(config.GetConnectionString("ReferenceToDB"))
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.TestingMenu:
                    return new TestingMenu();
                case MenuType.LogInMenu:
                    return new LogInMenu(new LogInBL(new CustRepository()));//(new CustomerCloudRepo(new database1Context(options))));
                //-----------------------------customer----------------------------------------------
                case MenuType.CurrentCustomer:
                    return new CurrentCustomer(new CustomerBL(new CustomerCloudRepo(new database1Context(options))));
                case MenuType.ShowCustomers:
                    return new ShowCustomers(new CustomerBL(new CustomerCloudRepo(new database1Context(options))));
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new CustomerBL(new CustomerCloudRepo(new database1Context(options))));
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                //------------------------------Store---------------------------------------------------
                case MenuType.ShowStores:
                    return new ShowStores(new StoreBL(new StoreCloudRepo(new database1Context(options))));
                case MenuType.AddStoreMenu:
                    return new AddStoreMenu(new StoreBL(new StoreCloudRepo(new database1Context(options))));
                case MenuType.StoreMenu:
                    return new StoreMenu();
                //----------------------------products-------------------------------------
                case MenuType.ShowProducts:
                    return new ShowProducts(new ProductBL(new ProductCloudRepo(new database1Context(options))));
                case MenuType.AddProductsMenu:
                    return new AddProductsMenu(new ProductBL(new ProductCloudRepo(new database1Context(options))));
                case MenuType.CurrentProduct:
                    return new CurrentProduct(new ProductBL(new ProductCloudRepo(new database1Context(options))));
                case MenuType.ProductMenu:
                    return new ProductMenu();
                //---------------------------LineItems-----------------------------------------
                case MenuType.AddLineItemsMenu:
                    return new AddLineItemsMenu(new LineItemBL(new LineItemCloudRepo(new database1Context(options))),
                                                new ProductBL(new ProductCloudRepo(new database1Context(options))),
                                                new StoreBL(new StoreCloudRepo(new database1Context(options))));
                case MenuType.LineItemMenu:
                    return new LineItemMenu();
                //-----------------------------Order-----------------------------------------------
                case MenuType.OrdersMenu:
                    return new OrdersMenu();
                //---------------------------------------------------------------------------------
                default:
                    return null;

            }
        }
    }
}