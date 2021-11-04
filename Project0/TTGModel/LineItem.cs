using System;
using System.Collections.Generic;

namespace TTGModel
{
    public class LineItem
    {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Product { get; set; }
        public int Store { get; set; }


        public Product ProductNavigation { get; set; }
        public Store StoreNavigation { get; set; }

        public List<ItemsInOrder> ItemsInOrder { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nQuantity: {Quantity}\nProduct: {Product}\nStore: {Store}\n";
        }
    }
}