using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            /*without linq we can show cheap books in this way*/
            var cheapBooks = new List<Book>();
            foreach(var book in books)
            {
                if(book.Price<10)
                    cheapBooks.Add(book);
            }

            foreach(var cheapBook in cheapBooks)
                Console.WriteLine(cheapBook.Title+ " " + cheapBook.Price);


            /*LINQ EXTENSION METHODS*/

            /*with linq it is easier*/
            var books2=new BookRepository().GetBooks();
            var cheapBooks2 = books
                                    .Where(book => book.Price < 10)
                                    .OrderBy(b => b.Title);

            foreach(var book in cheapBooks2)
                Console.WriteLine(book.Title + " " + book.Price);

            /*If we select only one column, it wil return string, so we don't need to write everything. Just book is enough*/
            var cheapBooks3 = books
                                    .Where(book => book.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);
            foreach (var book in cheapBooks3)
                Console.WriteLine(book);



            /*************************************************************************************************************/
                                                        /*LINQ QUERY OPERATORS*/
                                                 /***IT IS SAME WITH EXTENSION METHODS***/

            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;
            foreach(var book in cheaperBooks)
                Console.WriteLine(book);
            /*************************************************************************************************************/

            var book2 = books.Single(b => b.Title == "ASP.NET MVC"); //"single" returns only one record
            Console.WriteLine(book2.Title);

            //if we search what we don't have with "single", it will crash...
            //because it expect one result, so we use "SingleOrDefault". if we don't have that record, the default will be return (null)
            var book3 = books.SingleOrDefault(b => b.Title == "ASP.NET MVCsfasdf"); 
            Console.WriteLine(book3 == null); // we can use if book not null.. write name

            var book4 = books.First(b => b.Title == "C# Advanced Topics"); //it will return the first record
            Console.WriteLine(book4.Price);


            var book5 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics"); //it will return the first record
            Console.WriteLine(book5 == null); // we can use if book not null.. write name

            var book6 = books.Last(b => b.Title == "C# Advanced Topics"); //it will return the first record
            Console.WriteLine(book6.Price);

            var book7 = books.LastOrDefault(b => b.Title == "C# Advanced Topics"); //it will return the first record
            Console.WriteLine(book7 == null); // we can use if book not null.. write name


            /*************************************************************************************************************/
            var pagedBooks = books.Skip(2).Take(3); //this is for table data. skip 2 objects and take 3 objects next
            
            foreach(var book in pagedBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }

            /*We can use this one to show for example 10 record each page, and we can multiply skip with the page number!*/
            /*************************************************************************************************************/

            var book8 = books.Count();
            Console.WriteLine(book8);

            var bookprice = books.Max(b=> b.Price);
            Console.WriteLine(bookprice);

            var bookprice2 = books.Min(b => b.Price);
            Console.WriteLine(bookprice2);

            var sumTotal = books.Sum(b => b.Price);
            Console.WriteLine(sumTotal);

/*

            books.Where(); //returns query
            books.Single(); //returns single record
            books.SingleOrDefault(); //if there is no record, return null

            books.First();
            books.FirstOrDefault();
            books.Last();
            books.LastOrDefault();


            books.Min();
            books.Average();
            books.Max();

            books.Skip(5).Take(3);
  */
            }
    }
}

/*
 * Language Integrated Query
 * Gives you the capability to query objects 
 * 
 * 
 * You can query
 * Objects in memory
 * Databases
 * XML
 * ADO.NET Data Sets
 * 
 

 */