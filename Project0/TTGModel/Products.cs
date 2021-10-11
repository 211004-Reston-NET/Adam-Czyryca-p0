using System;
namespace TTGModel
{
    /*properties:
     name
     price
     description
     category
    */
    public class Products
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        
    }
}
