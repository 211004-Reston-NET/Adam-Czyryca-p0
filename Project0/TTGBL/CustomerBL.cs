using System.Collections.Generic;
using TTGDL;
using TTGModel;

namespace TTGBL
{
    public class CustomerBL : ICustomerBL
    {
        //define an Interface object to allow usage of all classes inhireting that method
        private ICustRepository _custRepo;
        // this classes constructor
        public CustomerBL(ICustRepository p_custRepo)
        {
            _custRepo=p_custRepo;
        }

        public Customer AddCustomer(Customer p_cust)
        {
           return _custRepo.AddCustomer(p_cust);
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listOfCustomers = _custRepo.GetAllCustomers();
            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                listOfCustomers[i].Name = listOfCustomers[i].Name.ToUpper();
            }
            return listOfCustomers;
        }
    }
}