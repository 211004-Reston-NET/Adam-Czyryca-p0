using System.Collections.Generic;
using TTGModel;

namespace TTGBL
{
    public interface IProductBL
    {
        /// <summary>
        /// get a list of all product obj in json file 
        /// </summary>
        /// <returns></returns>
        List<Products> GetAllProducts();

        /// <summary>
        /// adds a singular product obj to the json file
        /// </summary>
        /// <param name="p_prod"></param>
        /// <returns></returns>
        Products AddProduct(Products p_prod);
    }
}