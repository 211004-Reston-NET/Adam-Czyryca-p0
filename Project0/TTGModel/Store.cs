using System;
using System.Text.RegularExpressions;
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
            set 
            { 
                /*
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("Name can only hold letters!");
                }
                */
                _name = value;
            }
        }
        
        public string Address{get; set;}
        
        public string ProdList{get; set;}
        
        public string OrderList{get; set;}

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}";
        }
    }
}
