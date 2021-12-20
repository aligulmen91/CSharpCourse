using System;

namespace _040Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}

/*This is how we create generic list, we don't need to define for all data types and 
 we don't store as an object, so it is not affecting performance*/