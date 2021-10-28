using System.Collections.Generic;
using System.Linq;
using TTGModel;
using Entity = TTGDL.Entities;
using Model = TTGModel;

namespace TTGDL
{
    public class ProductCloudRepo : IProductRepo
    {
        private Entity.database1Context _context;

        public ProductCloudRepo(Entity.database1Context p_context)
        {
            _context = p_context;
        }

        public Product AddProduct(Product p_Product)
        {
            _context.Products.Add
              (
                 new Entity.Product()
                 {
                    Name = p_Product.Name,
                    Price = p_Product.Price,
                    Description = p_Product.Description,
                    Catagory = p_Product.Catagory
                 }
             );
            _context.SaveChanges();
            return p_Product;
        }


        public List<Model.Product> GetAllProducts()
        {
            //method syntax
            return _context.Products.Select(prod =>
                new Model.Product()
                {
                    Name = prod.Name,
                    Price = prod.Price,
                    Description = prod.Description,
                    Catagory = prod.Catagory
                }

            ).ToList();
        }

        public Model.Product GetProductByID(int p_prodID)
        {
            Entity.Product ProdToFind = _context.Products.Find(p_prodID);
            return new Model.Product()
            {
                Id = ProdToFind.Id,
                Name = ProdToFind.Name,
                Price = ProdToFind.Price,
                Description = ProdToFind.Description,
                Catagory = ProdToFind.Catagory
            };

        }
    }
}