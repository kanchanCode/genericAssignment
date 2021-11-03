using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class UC1
    {
        public int max(int a,int b,int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
              
                    Console.WriteLine(a+" is the greatest number");
                return a;
               
            }
            else if (b.CompareTo(a)>0 && b.CompareTo(c) > 0)
            {
                
                    Console.WriteLine(b+" is greatest number");
                return b;
               
            }
            else
            {
                Console.WriteLine(c+ " is the greatest number");
                return c;
            }
        }
    }
}
