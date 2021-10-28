using System.Collections.Generic;
using TTGModel;
using TTGDL;

namespace TTGBL
{
    public class LineItemBL : ILineItemBL
    {
        
        private ILineItemRepo _LineRepo;

        private IProductBL _prodBL;
        private IStoreBL _storeBL;

        public LineItemBL(ILineItemRepo p_Line)
        {
            _LineRepo=p_Line;
        }


        public LineItem AddLineItem(LineItem p_LineItem)
        {
            return _LineRepo.AddLineItem(p_LineItem);
        }

        public List<LineItem> GetAllLineItems()
        {
            List<LineItem> ListOfLineItems = _LineRepo.GetAllLineItems();
     
            return ListOfLineItems;
        }
    }
}