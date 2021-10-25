using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class LogInMenu : IMenu
    {
        //private static Customer SingletonCustomer._cust = new Customer();
        public ILogInBL _ICustBL;
        public LogInMenu(ILogInBL p_CustBL)
        {
            _ICustBL = p_CustBL;
        }
        public void Menu()
        {
            Console.WriteLine(
            "___________________________\n" +
            "Welcome to the LogIn Menu\n" +
            $"[1] - Name: {SingletonCustomer.Customer.Name}\n" +
            $"[2] - Email/Phone: {SingletonCustomer.Customer.EmailPhone} \n" +
            "[3] - LogIn\n" +
            "[0] - Exit\n" +
            "____________________________"
            );
        }

        public MenuType Navigation()
        {
            String UserChoice = Console.ReadLine();
            switch (UserChoice)
            {
                case "3":
                    /*
                    List<Customer> ListOfCustomers = _ICustBL.GetAllCustomers();
                    foreach (Customer customer in ListOfCustomers)
                    {
                        if (customer.Name == _cust.Name.ToUpper() && customer.EmailPhone == _cust.EmailPhone)
                        {
                            //return MenuType.OrdersMenu;
                            return MenuType.TestingMenu;
                        }
                    }
                    */

                    Boolean match = _ICustBL.VerifyCustomerID(SingletonCustomer.Customer.Name, SingletonCustomer.Customer.EmailPhone);
                    if (match == true)
                    {
                        //Console.ReadLine();
                        return MenuType.TestingMenu;
                    }
                    return MenuType.LogInMenu;
                case "2":
                    Console.Write("Email/phone: ");
                    SingletonCustomer.Customer.EmailPhone = Console.ReadLine();
                    return MenuType.LogInMenu;
                case "1":
                    Console.Write("Name: ");
                    SingletonCustomer.Customer.Name = Console.ReadLine();
                    return MenuType.LogInMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please choose one of the choices provided");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}