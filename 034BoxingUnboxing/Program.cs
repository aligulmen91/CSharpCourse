using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Boxing*/
            int number = 10;
            object obj = number;

            //or
            object obj2 = 10;

            /*Unboxing*/
            int number2 = (int)obj;
            /*And and boxing and Unboxing*/
            /*
             have a performance penalty - because of extra obj creation
             be avoid if possible
             
             */

        }
    }
}
