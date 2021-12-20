using System.Collections.Generic;

namespace _042LambdaExpressions
{
    internal partial class Program
    {
        public class BookRepository
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book() {Title = "Title1", Price = 3},
                    new Book() {Title = "Title2", Price = 9},
                    new Book() {Title = "Title3", Price = 4}
                };
            }
        }

     
    }

    /*
     Lambda is an anonymous method
    -   no access modifier 
    -   no name
    -   no return statement
    For convenience : less code, more readable
    we use it with delegates
    in .net framework we have 2 different default delegate
    Func<> = returns a result
    Action<> = is void, no returns anything.
    So, if we are doing some maths, we use Func


    () => ....
    x => ....
    (x,y,z) => ...
     */
}
