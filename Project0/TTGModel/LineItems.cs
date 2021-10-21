using System;
namespace TTGModel
{
    public class LineItems
    {
        /*Properties:
         product
         quantity
        */

        private Products _product;
        public Products Product
        {
            get { return _product; }
            set { _product = value; }
        }
        
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        
    }
}