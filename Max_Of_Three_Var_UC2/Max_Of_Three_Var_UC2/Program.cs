using System;

namespace Max_Of_Three_Var_UC2
{
    class Program
    {
        static void Main(string[] args)
        {

            Maxvalue.FindMax(1.2, 33.3, 6.3);

            Console.WriteLine("----Testcase1----");
            double result1 = Testcase1.Max1(77.5, 5.3,7.3 );
            Console.WriteLine(result1);
            Console.WriteLine("----Testcase2----");
            double result2 = Testcase2.Max2(3.3, 45.6,6.5);
            Console.WriteLine(result2);
            Console.WriteLine("----Testcase3----");
            double result3 = Testcase3.Max3(3.3, 33.3, 58.6);
            Console.WriteLine(result3);
        }
    }
}
