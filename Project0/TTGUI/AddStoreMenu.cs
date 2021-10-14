using System;
using TTGModel;
using TTGBL;
namespace TTGUI
{
    public class AddStoreMenu : IMenu
    {
        
        private static Store _store = new Store();
        private IStoreBL _storeBL;//IStoreBL

        public AddStoreMenu(IStoreBL p_storeBL)//IstoreBL
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            
            Console.WriteLine("______________________________");
            Console.WriteLine("Adding a new Store");
            Console.WriteLine("Name - " + _store.Name);
            Console.WriteLine("Address - "+ _store.Address);
            Console.WriteLine("[3] - Add store");
            Console.WriteLine("[2] - Input value for Name");
            Console.WriteLine("[1] - Input value for Address");
            Console.WriteLine("[0] - Go Back");
            Console.WriteLine("______________________________"); 
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "3":
                    _storeBL.AddStore(_store);
                    Console.WriteLine("Store has been added successfully");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    _store.Name="";
                    _store.Address="";
                    return MenuType.AddStoreMenu;
                case "2":
                    _store.Name= Console.ReadLine();
                    return MenuType.AddStoreMenu;
                case "1":
                    _store.Address= Console.ReadLine();
                    return MenuType.AddStoreMenu;
                case "0": 
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine(" Enter a Valid option ");
                    return MenuType.CustomerMenu;
            }
        }
    }
}