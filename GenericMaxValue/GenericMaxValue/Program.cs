using System;

namespace GenericMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
           var res1= FindMax.Max<int>(10, 20, 30);
            Console.WriteLine(res1);
          var res2 = FindMax.Max<double>(10.3, 2.0, 3.0);
            Console.WriteLine(res2);
            var res3 = FindMax.Max<string>("Raj", "abay", "sujesh");
            Console.WriteLine(res3);

        }
    }
}
