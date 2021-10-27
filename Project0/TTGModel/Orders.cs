using System;
namespace TTGModel
{
    public class Orders 
    {
        /*properties:
         orderID
         list of line items
         storefront location the order was placed
         Total price
        */
        public int Id { get; set; }
        public int StoreFront { get; set; }
        public int Customer { get; set; }
        public double Total { get; set; }
        
        public Customer CustomerNavigation { get; set; }
    
        public Store StoreNavigation { get; set; }
    }

}