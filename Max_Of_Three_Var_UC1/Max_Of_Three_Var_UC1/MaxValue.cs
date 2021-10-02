using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Of_Three_Var_UC1
{
    class MaxValue
    {
        public static void findmax(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first is greater");

            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second is greater");

            }
            else 
            {
                Console.WriteLine("third is greater");

            }
        }


    }
}
