using System;

namespace _040Generics
{
    public class Utilities
    {
       
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }


        //where T : IComparable
        //where T : Product
        //where T : struct
        //where T : class
        //where T : new()
        public T Max<T>(T a, T b) where T : IComparable
        {

            return a.CompareTo(b) > 0 ? a : b;
        }
    }

   
}

/*This is how we create generic list, we don't need to define for all data types and 
 we don't store as an object, so it is not affecting performance

 As you see, we have book list, or int list, or whatever. we can use generic list for all.
and it is not storing as an object. So, efficiency will be higher

 But normally we already have generic lists in .net so, we don't need creating new one like this
"System.Collections.Generic" search it

 
 Dictionary is data structre to store data hash tables, we use generic lists for it*/