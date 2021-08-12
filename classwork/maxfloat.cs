using System;
using System.Collections.Generic;
using System.Text;

namespace classwork
{
    class maxdouble
    {
        public double Maximumint(double first, double second, double third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            return first;
        }
    }
}