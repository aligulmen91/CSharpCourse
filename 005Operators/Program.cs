using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Postfix Increment*/
            int a = 1;
            int b = a++; /* We assign a to b first, and then we increase a. So, b will be 1 and a will be 2 */
            Console.WriteLine("postfix increment b= a++; a : " + a + " b : " + b);

            /*Prefix Increment*/
            a = 1;
            b = ++a; /* We increase a first, and then we assign a to b. So, b will be 2 and a will be 2 */
            Console.WriteLine("prefix increment b= a++; a : " + a + " b : " + b);


            /* Assignment Operators */
            a = 12;
            b = 12;
            a += 3; /* a = a + 3 */
            b /= 3; /* b = b / 3 */
            Console.WriteLine("assignment operators (values 12) a+=3 , b/=3 ;  a : " + a + " b : " + b);

            a = 10;
            b = 3;
            Console.WriteLine("float 10/3 :  " + (float)a / (float)b  );   /* 3.33333 */



        }
    }
}
