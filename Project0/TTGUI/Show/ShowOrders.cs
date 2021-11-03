using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class ShowOrders : IMenu
    {
        private IOrderBL _orderBL;
        private IStoreBL _storeBL;
        public ShowOrders(IOrderBL p_orderBL, IStoreBL p_storeBL)
        {
            _orderBL = p_orderBL;
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine(
                    "-------------------------\n" +
                    $"{SingletonCustomer.Customer.Name}'s Order History\n" +
                    "-------------------------\n"
                    );
            List<Orders> ListOfOrders = _orderBL.GetAllCustomerOrders(SingletonCustomer.Customer);
            foreach (Orders Order in ListOfOrders)
            {
                if (Order.Customer == SingletonCustomer.Customer.Id)
                {
                    Console.WriteLine(
                    "-------------------------\n" +
                    $"{Order}\n" +
                    "-------------------------\n"
                    );
                }

            }
            //Console.WriteLine("[1] - select Order to add items to");
            Console.WriteLine("[0] - Go back");
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter the Id of the Order to edit");
                    int _enteredOrderID = Convert.ToInt32(Console.ReadLine());
                    SingletonOrder.Order = _orderBL.GetOrder(_enteredOrderID);
                    SingletonStore.store = _storeBL.GetStoreById(SingletonOrder.Order.StoreFront);
                    Console.WriteLine($"{SingletonOrder.Order}\n has been updated to the current order");
                    Console.ReadLine();

                    return MenuType.ShowOrders;
                case "0":
                    return MenuType.OrdersMenu;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    return MenuType.ShowOrders;
            }
        }
    }
}