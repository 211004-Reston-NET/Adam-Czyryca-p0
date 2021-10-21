using System.Collections.Generic;
using TTGModel;
namespace TTGDL
{
    public interface ILineItemRepo
{
        /// <summary>
        /// this will return a list of stores stored in the database
        /// it will alse capitalize the store name
        /// </summary>
        /// <returns></returns>
        List<LineItems> GetAllLineItems();

        /// <summary>
        /// adds a new store to the database
        /// </summary>
        /// <param name="p_store"></param>
        /// <returns></returns>
        LineItems AddLineItem(LineItems p_store);
    }
}