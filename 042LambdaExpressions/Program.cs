using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042LambdaExpressions
{
    internal partial class Program
    {
        /*This is how we use normally square function*/
        static int Square(int number)
        {
            return number * number;
        }




        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));  /* call our function*/


            //for lambda :       args => expression
            //   number => number * number   // this is all we need for lambda for square function. the others are useless
          
            Func<int, int> squareWithLambda = number => number * number; // the last one is return value, the others the input values

            Console.WriteLine(squareWithLambda(5));
        




            //another one
            const int ourValue = 5;
            Func<int, int> multiplier = n => n * ourValue;
            Console.WriteLine(multiplier(4));


            /*normal way to get books*/
            var books = new BookRepository().GetBooks();
           var cheapBooks = books.FindAll(IsCheaperThan5Dollars);
          
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }


            /*With lambda finding cheapBooks*/
            var cheapBooksWithLambda = books.FindAll(book => book.Price < 5); // with this way, we don't need to create another function to find them
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }



        static bool IsCheaperThan5Dollars(Book book)  //IsCheaperThan5Dollars this is predicate
        {
            return book.Price < 5;
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
