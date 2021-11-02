using System.Collections.Generic;
using TTGModel;
namespace TTGBL
{
    public interface ILineItemBL
    {
        /// <summary>
        /// this will return a list of LineItemss LineItemsd in the database
        /// it will alse capitalize the LineItems name
        /// </summary>
        /// <returns></returns>
        List<LineItem> GetAllLineItems();

        /// <summary>
        /// get all line items at designated store
        /// </summary>
        /// <param name="_storeId"></param>
        /// <returns></returns>
        List<LineItem> GetAllLineItems(int _storeId);

        /// <summary>
        /// add line item 
        /// </summary>
        /// <param name="p_LineItem"></param>
        /// <param name="ProdName"></param>
        /// <param name="StoreName"></param>
        /// <returns></returns>
        LineItem AddLineItem(LineItem p_LineItem);
    }
}