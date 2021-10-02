using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Of_Three_Var_UC3
{
    class Testcase3
    {
        public static string Max3(string first, string second, string third)
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
