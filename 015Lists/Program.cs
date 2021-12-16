using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* arrays are fixed size, that means we can not change size of arrays after we create it
             lists are dynamic size data structers, so most of the time we use lists */
            
            var numbers = new List<int>();
            var numbers2 = new List<int>() { 1,2,3,4};

            /*
            Add()       : add an object to the list
            AddRange()  : to add list of objects or arrays
            Remove()    : remove from list
            RemoveAt()  : removes objects given index
            IndexOf()   : index of given object
            Contains()  : contains or not
            Count()     : count of list
             */

            numbers.Add(1);
            numbers.AddRange(numbers2);
            foreach(var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Index of 1 : " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1 : " + numbers.LastIndexOf(1)); /*we have three 1 in the array, so we may check last one*/

            Console.WriteLine("Count :" + numbers.Count);

            numbers.Remove(1); /*it will remove only first 1*/
            foreach (var number in numbers)
                Console.WriteLine(number);
            Console.WriteLine("Now, lets check the list without number 1 :");
            /*if we want to remove all 1, WE CAN NOT REMOVE WITH FOREACH LOOP, THE APPLICATION WILL BE CRASHED*/
            for (var i = 0; i < numbers.Count; i++)
            {
                if (i == 1)
                    numbers.Remove(i);
            }

           
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
