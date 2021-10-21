using System.Collections.Generic;
using TTGModel;
using TTGDL;
using System.Linq;

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

        public List<Products> GetProduct(string p_prodName)
        {
            
            List<Products> listOfProducts = _prodRepo.GetAllProducts();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfProducts.Where(rest => rest.Name.ToLower().Contains(p_prodName.ToLower())).ToList();
        }
    }
}