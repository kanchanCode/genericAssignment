using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class UC2
    {
        public double max(double a, double b, double c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {

                Console.WriteLine(a + " is the greatest number");
                return a;


            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {

                Console.WriteLine(b + " is greatest number");
                return b;

            }
            else
            {
                Console.WriteLine(c + " is the greatest number");
                return c;

            }
        }
    }
}
