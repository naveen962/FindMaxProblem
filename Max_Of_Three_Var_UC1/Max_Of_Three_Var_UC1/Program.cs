using System;

namespace Max_Of_Three_Var_UC1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MaxValue.findmax(10 ,20, 30);
            Console.WriteLine("----Testcase1----");
            var result1= Testcase1.Max1(40, 10, 20);
            Console.WriteLine(result1);
            Console.WriteLine("----Testcase2----");
            var result2 = Testcase2.Max2(10, 50, 20);
            Console.WriteLine(result2);
            Console.WriteLine("----Testcase3----");
            var result3 = Testcase3.Max3(10, 30, 60);
            Console.WriteLine(result3);
        }
    }
}
