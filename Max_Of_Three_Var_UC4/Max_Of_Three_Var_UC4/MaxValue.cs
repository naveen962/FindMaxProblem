using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Of_Three_Var_UC4
{
    public class MaxValue<T>where T:IComparable
    {
        
        public static T[] GetMax(T[] inputarray)
        {
            Array.Sort(inputarray);
            Console.WriteLine();
            return inputarray; 
           
        }

    }
}
