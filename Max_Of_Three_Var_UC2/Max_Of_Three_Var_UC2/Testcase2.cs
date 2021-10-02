using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Of_Three_Var_UC2
{
    class Testcase2
    {
        public static double Max2(double first, double second, double third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;

            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;

            }
            else
            {
                return third;

            }
        }
    }
}
