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
        List<LineItems> GetAllLineItems();

        /// <summary>
        /// adds a new LineItems to the database
        /// </summary>
        /// <param name="p_LineItems"></param>
        /// <returns></returns>
        LineItems AddLineItem(LineItems p_LineItems);
    }
}