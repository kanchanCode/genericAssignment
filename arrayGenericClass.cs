using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
   public class arrayGenericClass<T>
    {

        private T[] inputarray;
        public arrayGenericClass(T[] inputarray)
        {
            this.inputarray = inputarray;
        }
        public void toPrint()
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------");

        }


    }

}
