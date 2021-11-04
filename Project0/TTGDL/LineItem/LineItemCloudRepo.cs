using System.Collections.Generic;
using System.Linq;
using TTGModel;


namespace TTGDL
{
    public class LineItemCloudRepo : ILineItemRepo
    {
        private database1Context _context;

        public LineItemCloudRepo(database1Context p_context)
        {
            _context = p_context;
        }

        public LineItem AddLineItem(LineItem p_LineItem)
        {
            //method syntax
            _context.LineItems.Add(p_LineItem);
 
            _context.SaveChanges();
            return p_LineItem;

        }


        public List<LineItem> GetAllLineItems()
        {
            //method syntax
            return _context.LineItems.ToList();
        }

        public List<LineItem> GetAllLineItems(int p_storeId)
        {
            //method syntax
            return _context.LineItems
            .Where(item => item.Store == p_storeId)
            .Select(LineItem =>
                new LineItem()
                {
                    Id = LineItem.Id,
                    Quantity = LineItem.Quantity,
                    Product = LineItem.Product,
                    Store = LineItem.Store
                }

            ).ToList();
        }

        public LineItem GetMatchingLineItem(int p_itemID)
        {
            var result = _context.LineItems
                .FirstOrDefault<LineItem>(item =>
                    item.Id == p_itemID);
            return new LineItem()
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
                .FirstOrDefault<LineItem>(item => item.Id == p_itemID);
            query.Quantity = p_newQuantity;
            _context.SaveChanges();
        }
    }
}