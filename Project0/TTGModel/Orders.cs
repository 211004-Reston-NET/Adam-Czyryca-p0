using System;
namespace TTGModel
{
    public class Orders 
    {
        /*properties:
         list of line items
         storefront location the order was placed
         Total price
        */
        private string _lineList;
        public string LineList
        {
            get { return _lineList; }
            set { _lineList = value; }
        }
        
        private string _orderLocation;
        public string OrderLocation
        {
            get { return _orderLocation; }
            set { _orderLocation = value; }
        }
        
        private float _total;
        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }
        
    }
}