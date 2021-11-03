using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    class arrayGeneric
    {
        public static void toPrint<T>(T[] inputarray)
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------");

        }
       

    }

}
