using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
    }
}

/*CTRL + F5 start without debugging
 F9 put debug point
F5 Run in debug mode
F10 one line at a time
F11 Step Into next point
Shift + F11 Step out of method
Shift + F5 stop the debug modfe
DEBUG > Wındows > Watch > Watch 1  write variables to watch windows, in this way you can check all variables at a time

before doing any processing, check if it will work. Defensive programming
if (count > list.Count)
    throw new ArgumentOutOfRangeException("count","Count can not be greater than the size of list");


DEBUG > Wındows > Callstack Shows the methods run until now
DEBUG > Wındows > Autos    like watch table, but automatically it creates variable list
DEBUG > Wındows > Locals   like watch table, just list local variables
  */