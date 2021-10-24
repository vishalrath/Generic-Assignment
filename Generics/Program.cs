using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the Integer value:");
            Console.WriteLine("enter the first value:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second value:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third value:");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n maximum  value:{0} out of three number: ", Uc1MaxValue.MaximumValue(first, second, third));

            Console.WriteLine("************************");
            Console.WriteLine(" \n UC2 please enter the Decimal value:");
            Console.WriteLine("enter the first value:");
            double first1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second value:");
            double second1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the third value:");
            double third1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n maximum  value:{0} out of three float number: ", Uc2MaxxFloatValue.MaxValue(first1, second1, third1));

           Console.WriteLine("************************");
            Console.WriteLine(" \n UC3 please enter the Charecter:");
            Console.WriteLine("enter the first Charecter:");
            string first2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the second Charecter:");
            string second2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the third Charecter:");
            string third2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n maximum  Charecter value:{0} out of three Charecter: ", Uc3MaxString.MaximumString(first2, second2, third2));


            /* Console.WriteLine("please enter the  value:");
             Console.WriteLine("enter the first value:");
            // int first = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter the second value:");
            // int second = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter the third value:");
            // int third = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("\n maximum  value:{0} out of three number: ", Uc3Refactor_1and2.GenericMaximum(first, second, third));*/

            int[] arr = { 112, 344, 432, 55, 654 };
            Uc4GenericMethod<int> generic = new Uc4GenericMethod<int>(arr);
            generic.printMaxValue();

            Console.ReadLine();
        }
    }
}
