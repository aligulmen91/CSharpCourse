using System.Collections.Generic;

namespace _045LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks() {
            return new List<Book> {
        new Book() { Title ="ADO.NET Step by Step", Price = 5},
        new Book() { Title ="ASP.NET MVC", Price = 9.99f},
        new Book() { Title ="ASP.NET Web Api", Price = 12},
        new Book() { Title ="C# Advanced Topics", Price = 7},
        new Book() { Title ="C# Advanced Topics", Price = 9}
        };


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