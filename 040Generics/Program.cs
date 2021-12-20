using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { ISBN = "1111", Title = "C# Advanced" };
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());



            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
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