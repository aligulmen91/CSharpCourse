using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Overflowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* by default there is no overflow checking on C#
            we should write it manually.
            with 'checked' it will check overflow and throw an exception*/

            int number = 2147483647;                // the last number of integers
            number = number + 1;                    // we add 1 to see overflow
            Console.WriteLine(number);              // the result will return '-2147483648' which is starting of integer values

            /*To avoid this situation, lets use 'checked' */

            checked
            {
                int numberTwo = 2147483647;                
                numberTwo = numberTwo + 1;                 
                Console.WriteLine(numberTwo);              
            }

            /*This will check overflow and throw an exception, we will learn how to manage exceptions later*/
        }


    }
}
