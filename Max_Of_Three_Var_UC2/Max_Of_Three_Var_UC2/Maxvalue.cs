using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Of_Three_Var_UC2
{
    class Maxvalue
    {

        
            public static void FindMax(double first, double second, double third)
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


