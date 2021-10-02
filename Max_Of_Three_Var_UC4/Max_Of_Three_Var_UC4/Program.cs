using System;

namespace Max_Of_Three_Var_UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 10, 33, 43, 65, 22 };
            double[] doublearray = { 2.2, 6.4, 7.3, 4.2, 7.7 };
            string[] stringarray = { "naveen", "raj", "abhishek", "sujesh","kamalesh" };
         var res1  = MaxValue<int>.GetMax(intarray);
            int index1 = intarray.Length - 1;
            Console.WriteLine("the max value is"+res1[index1]);

         var res2 =  MaxValue<double>.GetMax(doublearray);
            int index2 = intarray.Length - 1;
            Console.WriteLine("the max value is" + res2[index2]);
         var res3 =  MaxValue<string>.GetMax(stringarray);
            int index3 = intarray.Length - 1;
            Console.WriteLine("the max value is" + res3[index3]);
        }
    }
}
