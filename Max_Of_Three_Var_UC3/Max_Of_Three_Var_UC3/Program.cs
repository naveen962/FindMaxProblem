using System;

namespace Max_Of_Three_Var_UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Testcase1-----");
            string res1=Testcase1.Max1("Peach", "Apple", "Banana");
            Console.WriteLine(res1);
            Console.WriteLine("-----Testcase2-----");
            string res2=Testcase2.Max2("Peach", "Strawberry", "Banana");
            Console.WriteLine(res2);
            Console.WriteLine("-----Testcase3-----");
            string res3=Testcase3.Max3("Banana", "Peach", "Tomato");
            Console.WriteLine(res3);

        }
    }
}
