using System.Collections.Generic;
using TTGModel;

namespace TTGBL
{
    public interface ICustomerBL
    {
        /// <summary>
        /// this will return a list of customers from the database
        /// </summary>
        /// <returns></returns>
        List<Customer> GetAllCustomers();

        /// <summary>
        /// adds a new customer to the database
        /// </summary>
        /// <param name="p_cust"></param>
        /// <returns></returns>
        Customer AddCustomer(Customer p_cust);

        /// <summary>
        /// will return single customer 
        /// </summary>
        /// <param name="p_custName"></param>
        /// <returns></returns>
        List<Customer> GetCustomer(string p_custName); 
    }
}