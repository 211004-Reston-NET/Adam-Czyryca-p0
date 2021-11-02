using System.Collections.Generic;
using System.Linq;
using TTGModel;
using Entity = TTGDL.Entities;
using Model = TTGModel;

namespace TTGDL
{
    public class ItemsInOrderCloudRepo : IItemsInOrderRepo
    {
        private Entity.database1Context _context;

        public ItemsInOrderCloudRepo(Entity.database1Context p_context)
        {
            _context = p_context;
        }

        public ItemsInOrder AddItemInOrder(ItemsInOrder p_items)
        {
            //method syntax
            _context.ItemsInOrders.Add
              (
                 new Entity.ItemsInOrder()
                 {
                     OrderId = p_items.OrderId,
                     LineItemId = p_items.LineItemId
                 }
             );
            _context.SaveChanges();
            return p_items;
        }


        public List<Model.ItemsInOrder> GetAllItemsInOrder()
        {
            //method syntax
            return _context.ItemsInOrders.Select(ItemsInOrder =>
                new Model.ItemsInOrder()
                {
                    OrderId = ItemsInOrder.OrderId,
                    LineItemId = ItemsInOrder.LineItemId
                }

            ).ToList();
        }


        // public List<Model.LineItem> GetLineItemsList(int p_storeId)
        // {
        //     return _context.LineItems
        //     .Where(item => item.Store == p_storeId)
        //     .Select(item =>
        //         new Model.LineItem()
        //         {
        //             ProductNavigation = new Model.Product()
        //             {
        //                 Name = item.ProductNavigation.Name,
        //                 Price = item.ProductNavigation.Price,
        //                 Description = item.ProductNavigation.Description,
        //                 Catagory = item.ProductNavigation.Catagory,
        //                 Id = item.ProductNavigation.Id
        //             },
        //             Quantity = item.Quantity,
        //             Id = item.Id,
        //             StoreFrontId = item.StorefrontId
        //         }
        //     ).ToList();
        // }
    }
}