using System.Collections.Generic;
using TTGModel;
namespace TTGDL
{
    public interface ICustRepository
    {
        /// <summary>
        /// will return a list of customer objects from the database
        /// </summary>
        /// <returns></returns>
        List<Customer> GetAllCustomers();

        /// <summary>
        /// will add a customer object to the database
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        Customer  AddCustomer(Customer cust);
    }
}