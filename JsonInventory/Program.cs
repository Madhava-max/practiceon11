using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonInventory
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            List<Item> crops = new List<Item>()
            {
                new Item(){Name="Rice",Weight=50,Price=1500 },
                new Item(){Name="Wheat",Weight=50,Price=1600 },
                new Item(){Name="Pulses",Weight=50,Price=1700 },


            };


            string strResultcrops = JsonConvert.SerializeObject(crops);
            File.WriteAllText(@"Item.json", strResultcrops);
            Console.WriteLine("stored");


            strResultcrops = string.Empty;
            strResultcrops = File.ReadAllText(@"Item.json");
           List<Item> resultItem = JsonConvert.DeserializeObject<List<Item>>(strResultcrops);

            //Console.WriteLine(resultItem.ToString());
           
            foreach (Item item in resultItem)
            {
               
                Console.WriteLine(item);
            }
            foreach (Item item in resultItem)
            {
                Console.WriteLine("the value of each item is : ");
                Console.WriteLine(item.Weight * item.Price);
            }






        }
    }
}
