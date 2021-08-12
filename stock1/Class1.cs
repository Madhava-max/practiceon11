using System;
using System.Collections.Generic;
using System.Text;

namespace cards
{
    class Stock
    {
        public int totalshare = 0;
        public int totalvalue = 0;
        public void Stockvalue(int a,int b,string c)
        {
           int stockvalue = a * b;
            Console.WriteLine("the value of the stock for" + c+" shares is :  " +stockvalue);
            totalvalue+= (a * b);
            Console.WriteLine("the total value of the stock is  " + totalvalue);
        }
       
        //public void totalshares(int numberofshares)
        //{
        //    totalshare += numberofshares;
        //}
        //public void TotalvalueofStock(int pricepershare, int noOfshares)
        //{
        //    totalvalue+=  (pricepershare * noOfshares);
        //    Console.WriteLine("the total value of stocks is " + totalvalue);
        //}

    }
}
