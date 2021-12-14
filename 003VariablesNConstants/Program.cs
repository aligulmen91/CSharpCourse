using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003VariablesNConstants
{
    internal class Program
    {
        /*CTRL + SHIFT + B   to compile application*/

        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Ali";
            bool isWorking = true;
            var numberTwo = 2; /*let the c# decide for the type, if you hover the 'var' you can see what system assign for the type*/
            const float Pi = 3.14f;

          /*  Pi = 4 will give the error, because constant values can not be changed inside program. they are read-only values*/
          
            /*If you go to 'View' > 'Object Browser' and search for data type, you can find all the functions that you can use for that data type */


            Console.WriteLine(number);
            /*for code snippet, we can write cw and press TAB twice instead of writing "Console.WriteLine" , or for variables, you can write two character to find all name */
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(numberTwo);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue); /* "{0} {1}" is format string, it will place values that write after comma , 
                                                                       int.MinValue, byte.MinValue.... int.MaxValue shows the range of data types*/
        }
    }
}
