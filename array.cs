using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class array
    {
        public static void toPrint(int[] inputarray)
        {
         foreach (int element in inputarray)
         {
                Console.WriteLine(element);
         }
            Console.WriteLine("-----------");

        }
        public static void toPrint(double[] inputarray)
        {
            foreach(double element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------");

        }

        public static void toPrint(char[] inputarray)

        { 
            foreach(char element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------");
        }

    }

}
