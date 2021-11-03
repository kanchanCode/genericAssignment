using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class UC4
    {
        public string max(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {

                Console.WriteLine(a + " is the greatest ");
                return a;

            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {

                Console.WriteLine(b + " is greatest ");
                return b;

            }
            else
            {
                Console.WriteLine(c + " is the greatest ");
                return c;

            }
        }
    }
}
