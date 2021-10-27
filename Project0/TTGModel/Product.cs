using System;
using System.Collections.Generic;

namespace TTGModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }

        public List<LineItems> LineItems { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}";
        }
    }
}
