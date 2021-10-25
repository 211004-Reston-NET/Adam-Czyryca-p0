using System;
using System.Collections.Generic;
using TTGBL;
using TTGModel;

namespace TTGUI
{
    public class ShowStores : IMenu
    {
        public IStoreBL _storeBL;//IstoreBL
        public ShowStores(IStoreBL p_storeBL)//IStoreBL
        {
            _storeBL=p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Stores in Database");
            List<Store> ListOfStores = _storeBL.GetAllStores();

            foreach (Store store in ListOfStores)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(store);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("[0] - Go back");
            
        }

        public MenuType Navigation()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    return MenuType.ShowStores;
            }
        }
    }
}