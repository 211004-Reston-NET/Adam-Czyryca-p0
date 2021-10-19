using System.Collections.Generic;
using TTGModel;
using TTGDL;

namespace TTGBL
{
    public class ProductBL : IProductBL
    {
        
        private IProductRepo _prodRepo; 

        public ProductBL(IProductRepo p_prod)
        {
            _prodRepo=p_prod;
        }


        public Products AddProduct(Products p_prod)
        {
            return _prodRepo.AddProduct(p_prod);
        }

        public List<Products> GetAllProducts()
        {
            List<Products> ListOfProducts = _prodRepo.GetAllProducts();
            for (int i = 0; i < ListOfProducts.Count; i++)
            {
                ListOfProducts[i].Name = ListOfProducts[i].Name.ToUpper();
            }
            return ListOfProducts;
        }
    }
}