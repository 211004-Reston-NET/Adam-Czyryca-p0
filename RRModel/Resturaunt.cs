using System;
using System.Text.RegularExpressions;

namespace RRModel
{
    public class Resturaunt 
    {
        //feild for City property 
        private string _city;
        private string _name;
      

        //City property of resturant 
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
            get { return _state; }
            set { _state = value; }
        }
        
        
      


    }
}
