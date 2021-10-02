using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMaxValue
{
   public class FindMax<T>where T:IComparable
    {
      public static T[] Max(T []inputarray)
      {
            Array.Sort(inputarray);
          
            return inputarray;
      }

    


   }
}
           
    

