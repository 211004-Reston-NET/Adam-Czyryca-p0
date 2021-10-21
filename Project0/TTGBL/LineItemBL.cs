using System.Collections.Generic;
using TTGModel;
using TTGDL;

namespace TTGBL
{
    public class LineItemBL : ILineItemBL
    {
        
        private ILineItemRepo _LineRepo; 

        public LineItemBL(ILineItemRepo p_Line)
        {
            _LineRepo=p_Line;
        }


        public LineItems AddLineItem(LineItems p_Line)
        {
            return _LineRepo.AddLineItem(p_Line);
        }

        public List<LineItems> GetAllLineItems()
        {
            List<LineItems> ListOfLineItems = _LineRepo.GetAllLineItems();
     
            return ListOfLineItems;
        }
    }
}