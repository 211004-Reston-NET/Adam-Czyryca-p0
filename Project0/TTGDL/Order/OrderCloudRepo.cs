using System.Collections.Generic;
using System.Linq;
using TTGModel;
using Entity = TTGDL.Entities;
using Model = TTGModel;

namespace TTGDL
{
    public class OrderCloudRepo : IOrdersRepository
    {
        private Entity.database1Context _context;

        public OrderCloudRepo(Entity.database1Context p_context)
        {
            _context = p_context;
        }
        public Model.Orders AddOrder(Model.Orders order)
        {
            _context.Orders.Add
            (
                new Entity.Order()
                {
                    StoreFront = order.StoreFront,
                    Customer = order.Customer,
                    Total = order.Total

                }
            );
            _context.SaveChanges();
            return order;
        }

        public List<Model.Orders> GetAllOrders()
        {
            return _context.Orders.Select(order =>
            new Model.Orders()
            {
                Id = order.Id,
                StoreFront = order.StoreFront,
                Customer = order.Customer,
                Total = order.Total
            }
            ).ToList();
        }

        public List<Model.Orders> GetAllCustomerOrders(Customer p_cust)
        {
            //method syntax
            return _context.Orders
            .Where(ord=> ord.Customer == p_cust.Id)
            .Select(order =>
                new Model.Orders()
                {
                    Id = order.Id,
                    StoreFront = order.StoreFront,
                    Customer = order.Customer,
                    Total = order.Total
                }

            ).ToList();
        }

        public Orders GetOrder(int p_orderId)
        {
            var result = _context.Orders
                .FirstOrDefault<Entity.Order>(_order =>
                    _order.Id == p_orderId);
            return new Model.Orders()
            {
                Id = result.Id,
                StoreFront= result.StoreFront,
                Customer = result.Customer,
                Total = result.Total
            };
        }

        public int GetOrderId (Orders p_order)
        {
            Orders order =GetOrder(p_order.Id);
            return order.Id;
        }
    }
}