using System;

namespace genericCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****Generics code*****");
            Console.WriteLine("1. To get max number(int)");
            Console.WriteLine("2. To get max number(float)");
            Console.WriteLine("3. To get max (char)");
            Console.WriteLine("4. To get max (string)");
            Console.WriteLine("5. To get max (generic<int>) using IComparable");
            Console.WriteLine("6. To get max from 5 inputs using generic class");

            Console.WriteLine("7. To print array (int,float and char)");
            Console.WriteLine("8. To print array (int,float and char) using generic in function");
            Console.WriteLine("9. To print array (int,float and char) using generic in class");
            Console.WriteLine("Enter your choice to get output");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.2, 3.4, 2.3, 5.6, 3.4, 4.5 };
            char[] charArray = { 'D', 'F', 'R', 'M', 'B' };

            switch (n)
            {
                case 1:
                    UC1 obj1 = new UC1();
                    obj1.max(10, 20, 30);
                    break;

                case 2:
                    UC2 obj2 = new UC2();
                    obj2.max(17.8, 15.3, 38.4);
                    break;
                case 3:

                    UC3 obj3 = new UC3();
                    obj3.max('a', 'q', 'm');
                    break;
                case 4:
                    UC4 obj4 = new UC4();
                    obj4.max("mansarovar", "mascot", "manisha");

                    break;
                case 6:
                    UC6<int>.max(40, 60, 20,34,45);
                    UC6<char>.max('m', 'a', 'v', 'k', 'e');

                    break;
                case 5:
                    //UC5<int> obj5 = new UC5<int>();
                    UC5<int>.max(40, 60, 20);
                    break;
                case 7:
                    array.toPrint(intArray);
                    array.toPrint(doubleArray);
                    array.toPrint(charArray);
                    break;
                case 8:

                    arrayGeneric.toPrint<int>(intArray);
                    arrayGeneric.toPrint<double>(doubleArray);
                    arrayGeneric.toPrint<char>(charArray);
                    break;
                case 9:
                    new arrayGenericClass<int>(intArray).toPrint();
                    new arrayGenericClass<double>(doubleArray).toPrint();
                    new arrayGenericClass<char>(charArray).toPrint();
                    break;

                default:
                    Console.WriteLine("invalid choice");
                    break;


            }

           


           
             
            
           

           

           
        }
    }
}
