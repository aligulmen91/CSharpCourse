using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ali Gulmen ";
            /*Trim will clean whitespaces before and end of string*/
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' '); /*Lets find the place of whitespace to cut first name and lastname*/
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' '); /*split with a char. and create an array*/
            Console.WriteLine("Firstname : " + names[0]);
            Console.WriteLine("Lastname : " + names[1]);

            var newName = fullName.Replace("Ali", "Ahmet");
            Console.WriteLine(newName);

            if (String.IsNullOrWhiteSpace(" ")) /*it will check null or empty. IsNullOrEmpty checks null or empty but not whitespace. so TRIM FIRST or use IsNullOrWhiteSpace !!*/
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);

            float price = 29.95f;
           
            Console.WriteLine(price.ToString());

        }
    }
}
