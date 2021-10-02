using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMaxValue
{
   public class FindMax
    {
      public static T Max<T>(T first,T second,T Third)where T:IComparable
      {
            if (first.CompareTo(second)>0 && first.CompareTo(Third)>0)
            {
                return first;
            }

           else if (second.CompareTo(first) > 0 && second.CompareTo(Third) > 0)
            {
                return second;
            }
            else
            {
                return Third;
            }


        }

    


   }
}
           
    

