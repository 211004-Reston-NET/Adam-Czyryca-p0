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
        
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        
        private string _emailPhone;
        public string EmailPhone
        {
            get { return _emailPhone; }
            set { _emailPhone = value; }
        }
        
        private string _orderList;
        public string OrderList
        {
            get { return _orderList; }
            set { _orderList = value; }
        }
        
    }
}