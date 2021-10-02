using System;

namespace GenclassMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxValue<int> mv1 = new MaxValue<int>(10, 20, 30);
            int resarray1=mv1.getMax();
            Console.WriteLine(resarray1);

            MaxValue<double> mv2 = new MaxValue<double>(10.3, 20.5, 3.0);
            double resarray2 = mv2.getMax();
            Console.WriteLine(resarray2);

            MaxValue<string> mv3 = new MaxValue<string>("Naveen","Raj","Abhi");
            string resarray3 = mv3.getMax();
            Console.WriteLine(resarray3);
        }
    }
}
