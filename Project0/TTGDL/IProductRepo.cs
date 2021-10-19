using System.Collections.Generic;
using TTGModel;

namespace TTGDL
{
    public interface IProductRepo
    {
        /// <summary>
        /// will add a new product to the database
        /// </summary>
        /// <param name="_prod"></param>
        /// <returns></returns>
        Products AddProduct(Products _prod);

        /// <summary>
        /// will retrive a list of all products 
        /// </summary>
        /// <returns></returns>
        List<Products> GetAllProducts();
    }
}