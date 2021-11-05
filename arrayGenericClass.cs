using System;
using System.Collections.Generic;
using System.Text;

namespace genericCode
{
    public class arrayGenericClass<T>
    {

        /*private T[] inputarray;
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
*/
        public T[] value;
        public arrayGenericClass(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;

        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[^1];
        }

            /*public T MaxMethod()
            {
                var Max = MaxValue(this.value);
                return Max;
            }*/

            public void PrintMax()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is : " + max);
            }


        }
    }

  
