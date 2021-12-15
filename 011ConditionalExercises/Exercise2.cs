using System;

namespace _011ConditionalExercises
{
    internal partial class Program
    {
        public class Exercise2
        {
            /*
            Write a program which takes two numbers from the console
            and displays the maximum of the two.
            */

            public static string compare(string num1, string num2)
            {
                var maxValue = Math.Max(SByte.Parse(num1), SByte.Parse(num2));

                return maxValue.ToString();
            }

        }

    }
}
