using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class UC5<T> where T : IComparable
    { 
        public T a, b, c;



        public UC5(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static T max(T a, T b, T c)
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
      /*  public T maxMethod()
        {
            T value = UC5<T>.max(this.a, this.b, this.c);
            return value;
        }
*/
    }
}
