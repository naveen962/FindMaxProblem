using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Of_Three_Var_UC5
{
   public class SortMaxValue<T>where T:IComparable
    {
        private T[] inputarray;
        public  SortMaxValue(T[] inputarray)
        {
            this.inputarray = inputarray;
           
        }
        public void PrintMax()
        {
            Array.Sort(inputarray);
            var maximum = this.inputarray[this.inputarray.Length - 1];

            GetSort(maximum);
            
        }

        public void GetSort(T Maximum)
        {

           
            Console.WriteLine("The Maximum value is: "+Maximum);

        }
    }
}
