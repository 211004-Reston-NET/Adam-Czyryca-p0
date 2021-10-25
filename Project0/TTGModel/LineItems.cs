using System;
namespace TTGModel
{
    public class LineItems
    {
        /*Properties:
         product
         quantity
        */

        private Product _product;
        public Product Product
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