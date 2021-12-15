using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011ConditionalExercises
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1*/
            //  Console.WriteLine("Please enter a number between 1-10 : ");
            //  Console.WriteLine(Exercise1.isValid(Console.ReadLine()));

            /*Exercise 2*/
            //  Console.WriteLine("Please enter first number : ");
            //  string num1 = Console.ReadLine();
            //  Console.WriteLine("Please enter second number : ");
            //  string num2 = Console.ReadLine();
            //  Console.WriteLine("The maximum value is : " + Exercise2.compare(num1,num2));

            /*Exercise 3*/
            //  Console.WriteLine("Please enter width : ");
            //  string num1 = Console.ReadLine();
            //  Console.WriteLine("Please enter height  : ");
            //  string num2 = Console.ReadLine();
            //  Console.WriteLine("Your image is " + Exercise3.isLandscape(num1,num2));

            /*Exercise 4*/
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Exercise4.testSpeed(speedLimit,carSpeed));

        }



    }
}
