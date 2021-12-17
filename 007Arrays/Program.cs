using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];  /*or var numbers = new int[3]; */
            numbers[0] = 1; 
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[3] { "ahmet", "mehmet", "mustafa" };
        }
    }
}
