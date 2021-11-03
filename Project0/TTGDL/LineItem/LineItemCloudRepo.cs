using System.Collections.Generic;
using System.Linq;
using TTGModel;
using Entity = TTGDL.Entities;
using Model = TTGModel;

namespace TTGDL
{
    public class LineItemCloudRepo : ILineItemRepo
    {
        private Entity.database1Context _context;

        public LineItemCloudRepo(Entity.database1Context p_context)
        {
            _context = p_context;
        }

        public LineItem AddLineItem(LineItem p_LineItem)
        {
            //method syntax
            _context.LineItems.Add
              (
                 new Entity.LineItem()
                 {
                     Quantity = p_LineItem.Quantity,
                     Product = p_LineItem.Product,
                     Store = p_LineItem.Store
                 }
             );
            _context.SaveChanges();
            return p_LineItem;

        }


        public List<Model.LineItem> GetAllLineItems()
        {
            //method syntax
            return _context.LineItems.Select(LineItem =>
                new Model.LineItem()
                {
                    Id = LineItem.Id,
                    Quantity = LineItem.Quantity,
                    Product = LineItem.Product,
                    Store = LineItem.Store
                }

            ).ToList();
        }

        public List<Model.LineItem> GetAllLineItems(int p_storeId)
        {
            //method syntax
            return _context.LineItems
            .Where(item => item.Store == p_storeId)
            .Select(LineItem =>
                new Model.LineItem()
                {
                    Id = LineItem.Id,
                    Quantity = LineItem.Quantity,
                    Product = LineItem.Product,
                    Store = LineItem.Store
                }

            ).ToList();
        }

        public Model.LineItem GetMatchingLineItem(int p_itemID)
        {
            var result = _context.LineItems
                .FirstOrDefault<Entity.LineItem>(item =>
                    item.Id == p_itemID);
            return new Model.LineItem()
            {
                Id = result.Id,
                Quantity = result.Quantity,
                Product = result.Product,
                Store = result.Store
            };
        }

        public void UpdateQuantity(int p_itemID, int p_newQuantity)
        {
            var query = _context.LineItems
                .FirstOrDefault<Entity.LineItem>(item => item.Id == p_itemID);
            query.Quantity = p_newQuantity;
            _context.SaveChanges();
        }
    }
}