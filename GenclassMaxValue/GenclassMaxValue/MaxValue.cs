using System;
using System.Collections.Generic;
using System.Text;

namespace GenclassMaxValue
{
   public class MaxValue<T> where T: IComparable
    {
        public T Take_input1, Take_input2, Take_input3; // declare veriables
        public MaxValue(T Take_input1, T Take_input2, T Take_input3) //Constructor
        {
            this.Take_input1 = Take_input1;
            this.Take_input2 = Take_input2;
            this.Take_input3 = Take_input3;
        }
        public  T getMax()
        {
            var MaxResult = this.Take_input1.CompareTo(Take_input2) > 0 ? Take_input1 : (this.Take_input2.CompareTo(Take_input3) > 0 ? Take_input2 : Take_input3); //Find maximum number/result

            Console.WriteLine("Maximum value is : " + MaxResult);

            return MaxResult;
        }
    }
}
