using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac=0;
            /*
            For Loops
            For Each Loops
            While Loops
            Do-While Loops
             */
            for (var i=0; i<10; i++)
            {
                if (i%2==0) /* even numbers */
                Console.WriteLine(i);
            }




            var isim = "Ali Gulmen"; /*strings are array of chars, so we can use it as isim[x]*/

            foreach(var character in isim)
            {
                Console.WriteLine(character);
            }




            while (sayac < 10){
                if (sayac % 2 == 1) /* odd numbers */
                    Console.WriteLine(sayac);
                sayac++;

            }

            sayac = 0;



            do
                {
                Console.WriteLine(sayac);
                    sayac++;
                } while (sayac < 10);






            while (true)
            {
                Console.WriteLine("Type Your Name : ");
             var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo: " + input);
            }

        }




       


    }
}
