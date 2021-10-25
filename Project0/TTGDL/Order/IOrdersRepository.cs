using System.Collections.Generic;
using TTGModel;

namespace TTGDL
{
    public interface IOrdersRepository 
    {
        Orders AddOrders();
        Orders GetOrder(int OrderID);
        List<Orders> GetAllOrders();
        
    }
}