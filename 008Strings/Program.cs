using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[3] { 1, 2, 3 };
            string firstName = "Ali";
            string lastName = "Gulmen";
            string name = firstName + " " + lastName;
            /* Or in easiar way, we can format it */
            string fullName = string.Format("{0} {1}", firstName, lastName);
            /*{0} {1} are placeholders,*/
            Console.WriteLine(fullName);

            /* If we want to write all element of array with joining character, we can use it in this way */
            string lists = string.Join(",", numbers);
            Console.WriteLine(lists);

            /*If we want to check every char seperatly, we can use string as an array of char*/
            name = "Ahmet";
            char firstChar = name[0];
            Console.WriteLine(firstChar);
            /* But we can not change any char in this way!!!! this is the read-only way */

          
            string path = "C:\\projects\\project1\\folder1";        /*we use special characters with \ char. */
            string path2 = @"C:\projects\project1\folder1";         /*or with @ char in front of string. */
        }
    }
}
