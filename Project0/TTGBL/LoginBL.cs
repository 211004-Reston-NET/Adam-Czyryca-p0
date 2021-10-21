using System;
using System.Collections.Generic;
using System.Linq;
using TTGDL;
using TTGModel;

namespace TTGBL
{
    public class LogInBL : ILogInBL
    {
        private ICustRepository _custRepo;

        public LogInBL(ICustRepository p_custRepo)
        {
            _custRepo = p_custRepo;
        }

        public Boolean VerifyCustomerID(string p_custName, string p_custEmailPhone)
        {
            List<Customer> listOfCustomer = _custRepo.GetAllCustomers();

            List<Customer> match = (listOfCustomer.Where(cust => cust.Name.ToLower().Contains(p_custName.ToLower())).ToList()).Where(cust => cust.EmailPhone.Contains(p_custEmailPhone)).ToList();
            if (match[0].Name == p_custName && match[0].EmailPhone == p_custEmailPhone)
            {
                return true;
            }
            return false;
        }
    }
}