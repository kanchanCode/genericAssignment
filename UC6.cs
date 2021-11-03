using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class UC6<T> where T : IComparable
    {
        public T a, b, c, d , e;



        public UC6(T a, T b, T c,T d,T e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public static T max(T a, T b, T c,T d,T e)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 && a.CompareTo(d)>0 && a.CompareTo(e)>0)
            {

                Console.WriteLine(a + " is the greatest ");
                return a;

            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 && b.CompareTo(d) > 0 && b.CompareTo(e) > 0)
            {

                Console.WriteLine(b + " is greatest ");
                return b;

            }
            else if (c.CompareTo(a) > 0 && c.CompareTo(d) > 0 && c.CompareTo(e) > 0 && c.CompareTo(b) > 0)
            {

                Console.WriteLine(c + " is greatest ");
                return c;

            }
            else if (d.CompareTo(a) > 0 && d.CompareTo(c) > 0 && d.CompareTo(d) > 0 && d.CompareTo(b) > 0)
            {

                Console.WriteLine(d + " is greatest number");
                return d;

            }
            else
            {
                Console.WriteLine(e + " is the greatest number");
                return e;
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
