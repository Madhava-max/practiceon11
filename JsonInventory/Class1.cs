using System;
using System.Collections.Generic;
using System.Text;


namespace JsonInventory
{
    public class Item
    {
       
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"crops info \n  \t  Name : {Name}, Weight : {Weight}, Price :{Price}";
        }

    }
    
}
