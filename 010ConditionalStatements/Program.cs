using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010ConditionalStatements
{
    internal partial class Program
    {
        /*There was Season enum here, we move it to Season.cs to be more clear*/


        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
                Console.WriteLine("It is morning.");
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("It is afternoon.");
            }
            else {
                Console.WriteLine("It is evening.");
            }

            
            
            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            /*Or we can write in different way*/
            price = (isGoldCustomer) ? 19.95f : 29.95f;
            /* value = condition ? if it is true : if it is false */




            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is Autumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("It is Spring");
                    break ;
                default:
                    Console.WriteLine("What happened?!?");
                    break;

            }


        }
    }
}
