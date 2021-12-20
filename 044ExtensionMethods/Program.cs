using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very very very very long blog post";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost );
        }
    }


    public static class StringExtensions //to create extension, it should be static
    {
        public static string Shorten(this String str,int numberofWords) // and we should put this before type

        {
            if (numberofWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");
            if (numberofWords == 0)  // if we dont have any word, return empty
                return "";
            var words = str.Split(' '); //if we have words, split them to an array
            if (words.Length <= numberofWords)  //less than the number we want
                return str;

          return string.Join(" ",words.Take(numberofWords))+"..."; //if it is long, take x words, and create new string
        }
    }


}

/*
 
 Allow us to add methods to an existing class without
- changing its source code
- creating new class that inherits from it
 
 AND WHY WE USE IT?????
for example in string method, we don't have shorten() function. but we want to cut the sentence with this function.
What can we do? we create new extension, with this way, we can use it however we want.


 public static class StringExtensions //to create extension, it should be static, first name of method (String) then Extensions
    {
        public static string Shorten(this String str,int numberofWords) // and we should put this before type

        {

        }
    }
 
 */