using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013RandomClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();  
           for (int i = 0; i < 10; i++)
            Console.WriteLine(random.Next(1,100));


            Console.WriteLine((int)'a'); /*ASCII number of a*//*if we want to write some random chars;*/
            for (int i = 0; i < 10; i++)
                Console.Write((char)random.Next(97, 122));
            Console.WriteLine("");

            /*if we want to create a password from char array, we should do like this; */
            var buffer = new char[10];

            for (int i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
