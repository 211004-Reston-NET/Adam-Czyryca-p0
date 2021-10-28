using System.Collections.Generic;

namespace TTGModel
{
    public class Customer 
    {
        /*properties:
         name
         address
         email/phone number
         list of orders
        */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailPhone { get; set; }

        public List<LineItem> OrderList{ get; set;}
        
        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nEmail/Phone: {EmailPhone}";
        }
    }
}