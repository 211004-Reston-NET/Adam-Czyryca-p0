using System.Collections.Generic;
using System.Linq;
using Entity = TTGDL.Entities;
using Model = TTGModel;

namespace TTGDL
{
    public class CustomerCloudRepo : ICustRepository
    {
        private Entity.database1Context _context;

        public CustomerCloudRepo(Entity.database1Context p_context)
        {
            _context = p_context;
        }

        
        public Model.Customer AddCustomer(Model.Customer p_cust)
        {
            _context.Customers.Add
            (
                new Entity.Customer()
                {
                    Name = p_cust.Name,
                    Address = p_cust.Address,
                    EmailPhone = p_cust.EmailPhone

                }
            );
            _context.SaveChanges();
            return p_cust;
        }

        public List<Model.Customer> GetAllCustomers()
        {
            //method syntax
            return _context.Customers.Select(cust =>
                new Model.Customer()
                {
                    Id = cust.Id,
                    Name = cust.Name,
                    Address = cust.Address,
                    EmailPhone = cust.EmailPhone

                }

            ).ToList();

            //query syntax 
            // var result = (from cust in _context.Customers
            //                 select cust);
            // List<Model.Customer> ListOfCustomers = new List<Model.Customer>();
            // foreach (var cust in result)
            // {
            //     ListOfCustomers.Add(new Model.Customer()
            //     {
            //         Id = cust.Id,
            //         Name = cust.Name,
            //         Address = cust.Address,
            //         EmailPhone = cust.EmailPhone

            //     });
            // }
            // return ListOfCustomers;
        }
    }
}