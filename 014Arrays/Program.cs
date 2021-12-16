using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014ArraysNLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*There are two types of multidimension array
             Rectangular and Jagged
            rectangular 
            x x x x
            x x x x
            x x x x

            jagged
            x x x x
            x x x
            x x x x x x
            x x x x x

             */

            var numbers = new[] { 3, 9, 8, 13, 46, 32 };
            var anotherarray = new int[3];
            
            //Length
            Console.WriteLine("Length : " +numbers.Length);
            
            //IndexOf()
            var index = Array.IndexOf(numbers, 46);
            Console.WriteLine("Index of 46 : " + index);

            //clear
            Array.Clear(numbers, 0, 1); /* array, starting index, length... they will be zero because of they are integer. */

            //copy
            Array.Copy(numbers, anotherarray, 3);
            Console.WriteLine("Another Array is now :");
            foreach(int i in anotherarray)
                Console.WriteLine(i);


            //sort
            Array.Sort(anotherarray);
            Console.WriteLine("Sorted array is now :");
            foreach (int i in anotherarray)
                Console.WriteLine(i);


            //reverse
            Array.Reverse(anotherarray);
            Console.WriteLine("Reversed array is now :");
            foreach (int i in anotherarray)
                Console.WriteLine(i);

            /*rectangular 2D array*/
            var matrix = new int[3, 5]
            {
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 11,12,13,14,15}
            };
            var element = matrix[0, 2];
         //   Console.WriteLine(element);

            /*rectangular 3D array*/
            var colors = new int[3, 4, 5];

            /* Jagged array */

            var newArray = new int[3][]; /*we define 3 row for our jagged array, and we leave blank length*/
            newArray[0] = new int[4]; /*and for each row, we define the length seperately*/
            newArray[1] = new int[5];
            newArray[2] = new int[2];
        }
    }
}
