using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find the max number");
            //maxString var = new maxString();
            //string result =var.MaximumString("madhava", "rajyam", "ANJALI");
            //Console.WriteLine(result);
            //maxint vari = new maxint();
            //int result = vari.Maximumint(2005,19240,027443);
            //Console.WriteLine(result); 
            maxdouble vari = new maxdouble();
            double result = vari.Maximumint(2005.01, 19240.00, 027443.98);
            Console.WriteLine(result);
            //int[] intArray = { 192, 12883, 12373, 1371 };

            //GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            //generic.PrintMax();

        }
    }
}
