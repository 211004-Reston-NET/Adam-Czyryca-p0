using System.Collections.Generic;
using TTGDL;
using Model =TTGModel;

namespace TTGBL
{
    public class OrderBL : IOrderBL
    {
        public IOrdersRepository _orderRepo;

        public OrderBL(IOrdersRepository p_order)
        {
            _orderRepo =p_order;
        }


        public Model.Orders AddOrders(Model.Orders p_order)
        {
            return _orderRepo.AddOrder(p_order);
        }

        public List<Model.Orders> GetAllOrders()
        {
            List<Model.Orders> listOfOrders = _orderRepo.GetAllOrders();
            
            return listOfOrders;
        }

        public Model.Orders GetOrder(int p_orderId)
        {
            return _orderRepo.GetOrder(p_orderId);
        }
    }
}