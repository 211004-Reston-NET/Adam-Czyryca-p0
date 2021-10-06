using System;
using System.Text.RegularExpressions;

namespace RRModel
{
    public class Resturaunt 
    {
        
        private string _city;
        public string City
        {
            get
            { 
                return _city; 
            }
            set 
            { 
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception ("City can only hold letters");
                }
                _city = value; 
            }
        }  

        private string _state;
        public string State
        {
            get 
            { 
                return _state; 
                
            }
            set 
            { 
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception ("State can only hold letters");
                }
                _state = value; 
            }
        }
        
        private string _name;
        public string Name
        {
            get 
            { 
                return _name; 
                
            }
            set 
            { 
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception ("State can only hold letters");
                }
                _name = value; 
            }
        }
    }
}
