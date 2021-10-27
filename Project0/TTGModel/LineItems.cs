using System;
namespace TTGModel
{
    public class LineItems
    {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Product { get; set; }
        public int Store { get; set; }


        public Product ProductNavigation { get; set; }
        public Store StoreNavigation { get; set; }
    }
}