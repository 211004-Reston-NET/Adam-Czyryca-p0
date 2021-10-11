using System;

namespace TTGModel
{
    public class Store
    {
        /*Properties:
         name
         address
         list of products
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
        
        private string _prodList;
        public string ProdList
        {
            get { return _prodList; }
            set { _prodList = value; }
        }
        
        private string _orderList;
        public string OrderList
        {
            get { return _orderList; }
            set { _orderList = value; }
        }
    }
}
