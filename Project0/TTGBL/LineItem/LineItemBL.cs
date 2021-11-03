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
            _LineRepo = p_Line;
            
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

        public List<LineItem> GetAllLineItems(int p_storeId)
        {
            List<LineItem> ListOfLineItems = _LineRepo.GetAllLineItems(p_storeId);

            return ListOfLineItems;
        }

        public LineItem GetMatchingLineItem(int p_itemID)
        {
            return _LineRepo.GetMatchingLineItem(p_itemID);
        }

        public void UpdateQuantity(int p_itemID, int p_newQuantity)
        {
            _LineRepo.UpdateQuantity(p_itemID, p_newQuantity);
        }

    }
}