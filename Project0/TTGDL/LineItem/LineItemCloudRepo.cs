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
                    Quantity = LineItem.Quantity,
                    Product = LineItem.Product,
                    Store = LineItem.Store
                }

            ).ToList();
        }

    }
}