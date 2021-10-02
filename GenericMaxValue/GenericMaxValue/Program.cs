using System;

namespace GenericMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intarray = { 10, 30, 20 };
            double[] doublearray = { 22.2, 53.3, 44.4 };
            string[] stringarray = { "Naveen", "Raj", "Abhishek" };

           int[] res1array= FindMax<int>.Max(intarray);
            int index1= res1array.Length - 1;
            Console.WriteLine(res1array[index1]);
           double[]res2array= FindMax<double>.Max(doublearray);
            int index2 = res1array.Length - 1;
            Console.WriteLine(res2array[index2]);
            string[]res3array= FindMax<string>.Max(stringarray);
            int index3 = res1array.Length - 1;
            Console.WriteLine(res3array[index3]);
        }
    }
}
