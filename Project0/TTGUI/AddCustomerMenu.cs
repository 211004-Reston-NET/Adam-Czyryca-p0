using System;
using TTGModel;
using TTGBL;
namespace TTGUI
{
    public class AddCustomerMenu : IMenu
    {
        //create a new customer obj named _cust
        private static Customer _cust = new Customer();

        //create an undefined ICustomerBL obj names _custbl
        public ICustomerBL _custBL;

        //this classes constructor
        public AddCustomerMenu(ICustomerBL p_custBL)
        {
            //instantiate _custBL with p_custBL
            _custBL = p_custBL;
        }
        public void Menu()
        {
        
            Console.WriteLine(
            "____________________________\n"+
            "Add Customer Menu\n"+
            $"Name - {_cust.Name}\n"+
            $"Address -{_cust.Address}\n"+
            $"email/phone number - {_cust.EmailPhone}\n"+
            "[4] - Submit Information\n"+
            "[3] - Enter your for Name\n"+
            "[2] - Enter your for Address\n"+
            "[1] - Enter your Email or Phone number\n"+
            "[0] - Go Back to Customer Menu\n"+
            "______________________________\n"
            );
            
        }

        public MenuType Navigation()
        {
            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "4":
                    _custBL.AddCustomer(_cust);
                    Console.WriteLine("Store has been added successfully");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    _cust.Name="";
                    _cust.Address="";
                    _cust.EmailPhone="";
                    return MenuType.AddCustomerMenu;
                case "3":
                    _cust.Name = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "2":
                    _cust.Address = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "1":
                    _cust.EmailPhone = Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                case "0":
                    return MenuType.CustomerMenu;
                default:
                    Console.WriteLine("Please choose one of the options listed above");
                    Console.WriteLine("press enter to continue...");
                    Console.ReadLine();
                    return MenuType.AddCustomerMenu;
            }
        }
    }
}