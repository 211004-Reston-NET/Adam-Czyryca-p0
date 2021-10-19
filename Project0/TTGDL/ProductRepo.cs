using System.Collections.Generic;
using TTGModel;
using System.Text.Json;
using System.IO;

namespace TTGDL
{
    public class ProductRepo : IProductRepo
    {
        private const string  _filePath = "./../TTGDL/Database/Products.json";

        private string _jsonString;

        public Products AddProduct(Products _prod)
        {
            List<Products> ListOfProducts = GetAllProducts();
            ListOfProducts.Add(_prod);

            _jsonString = JsonSerializer.Serialize(ListOfProducts, new JsonSerializerOptions{WriteIndented=true});

            File.WriteAllText(_filePath, _jsonString);

            return _prod;

        }

        public List<Products> GetAllProducts()
        {
            _jsonString = File.ReadAllText(_filePath);

            return JsonSerializer.Deserialize<List<Products>>(_jsonString);
        }

    
    }
}