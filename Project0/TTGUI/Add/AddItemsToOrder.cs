using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class AddItemsToOrder : IMenu

    {
        private static ItemsInOrder ItemAdd = new ItemsInOrder();
        private IItemsInOrderBL _ItemsInOrderBL;
        private ILineItemBL _lineItemBL;
        private IOrderBL _orderBL;

        private IProductBL _prodBL;
        
        public AddItemsToOrder(IItemsInOrderBL p_ItemsInOrderBL, ILineItemBL p_lineItemBL, IOrderBL p_orderBL, IProductBL p_prodBL)//IprodBL
        {
            _ItemsInOrderBL = p_ItemsInOrderBL;
            _lineItemBL = p_lineItemBL;
            _orderBL = p_orderBL;
            _prodBL = p_prodBL;
        }

        public void Menu()
        {
            Console.WriteLine("Add Products To an Order ");
            List<LineItem> ListOfLineItems = _lineItemBL.GetAllLineItems(SingletonStore.store.Id);
            //_prodBL.GetProductByID();

            foreach (LineItem item in ListOfLineItems)
            {
                Product prodPrint = new Product();
                prodPrint =_prodBL.GetProductByID(item.Product);
                Console.WriteLine(
                "------------------------\n" +
                $"ID:{item.Id}\n" +
                $"In Stock:{item.Quantity}\n" +
                $"{prodPrint.ToString()}\n" +
                "------------------------\n"
                //$"{prodToPrint.ToString()}\n"
                );

            }
            //Console.WriteLine("Use provided ID when choosing products to add");
            Console.WriteLine("[1] - Add product");
            Console.WriteLine("[0] - Go back");

        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter the name of a Product to add it to an order");
                    SingletonProduct.product.Name = Console.ReadLine();
                    List<Orders> ListOfOrders = new List<Orders>();
                    List<LineItem> ListOfLineItems = new List<LineItem>();
                    List<Product> ListOfProducts = new List<Product>();
                    ListOfProducts = _prodBL.GetProduct(SingletonProduct.product.Name);
                    ListOfOrders = _orderBL.GetAllOrders();
                    ListOfLineItems = _lineItemBL.GetAllLineItems();
                    int cust_ID = SingletonCustomer.Customer.Id;
                    //int lineItem_Id;
                    int prod_id;
                    Console.WriteLine($"Add {ListOfProducts[0].Name} to Order [Y] [N]?");
                    String result = Console.ReadLine();
                    if (result.ToUpper() == "Y")
                    {
                        prod_id = ListOfProducts[0].Id;
                        foreach (LineItem item in ListOfLineItems)
                        {
                            if ((item.Store == SingletonStore.store.Id) && (item.Product == prod_id))
                            {
                                //lineItem_Id = item.Id;
                                ItemAdd.LineItemId = (int)item.Id;
                                ItemAdd.OrderId = SingletonOrder.Order.Id;
                                _ItemsInOrderBL.AddItemsInOrder(ItemAdd);
                                Console.WriteLine("item added");
                            }
                            else
                            {
                                Console.WriteLine("item not added");
                            }

                        }
                    }

                    SingletonProduct.product.Name = Console.ReadLine();
                    return MenuType.AddItemsToOrder;
                case "0":
                    return MenuType.ProductMenu;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    return MenuType.AddItemsToOrder;
            }
        }
    }
}