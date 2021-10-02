using System;

namespace Max_Of_Three_Var_UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 10, 33, 43, 65, 22 };
            double[] doublearray = { 2.2, 6.4, 7.3, 4.2, 7.7 };
            string[] stringarray = { "naveen", "raj", "abhishek", "sujesh", "kamalesh" };
            SortMaxValue<int> mv1 = new SortMaxValue<int>(intarray);
            mv1.PrintMax();
            
            SortMaxValue<double> mv2 = new SortMaxValue<double>(doublearray);
            mv2.PrintMax();
            
            SortMaxValue<string> mv3 = new SortMaxValue<string>(stringarray);
            mv3.PrintMax();
           


        }
    }
}


