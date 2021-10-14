using System;
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
        
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        
        public string Address{ get; set;}
        public string EmailPhone {get; set;}
        public string OrderList{ get; set;}
        
        
    }
}