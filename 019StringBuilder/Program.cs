using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder(/*you can write base string here*/);
            builder.Append('-',10);     /*append - char 10 times*/
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();        /* append new line */
            builder.Append('-', 10);     /* append - char 10 times */
            Console.WriteLine(builder);

            builder.Replace('-', '*');   /* replace all characters with new ones */
            Console.WriteLine(builder);

            builder.Remove(0, 10); /* start from zero and remove 10 chars*/
            Console.WriteLine(builder);

            builder.Insert(0, new string('_', 10)); /* 0 is the place where we want to add, and new string is the string that we want to add */
            Console.WriteLine(builder);

            Console.WriteLine(builder[0]); /*we can show which char we want*/



            /*In stringBuilder we can write all of the codes together. For example ;
            builder.Append('-', 10);    
                    .AppendLine();
                    .Append("Header");
                    .AppendLine();       
                    .Append('-', 10);   
                    .Replace('-', '*');  
                    .Remove(0, 10); 
                    .Insert(0, new string('_', 10));
            Console.WriteLine(builder);
            */

        }
    }
}
