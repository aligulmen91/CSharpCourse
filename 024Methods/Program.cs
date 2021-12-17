using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024Methods
{

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculator
    {

        /*overloading methods, having a method with the same name but different signatures one example for overloading methods ; */
        /*step 1*/
        public void Add(int n1, int n2) { } /* method */
        public void Add(int n1, int n2, int n3) { } /* method */
        public void Add(int n1, int n2, int n3,int n4) { } /* method */

        /*this is a way overloading but not right way for this solution. because sometimes we want to add 20 numbers, and it is not good.
         so, we can use only one method with array, it is more usable. We use overloading methods, for different kind of inputs.
        */
        /*step 2*/
  //      public void Add(int[] numbers) { } /* this method enough */
        /*now we have only one method, and it is more usable. but the problem is when we want to use it, everytime we should create an istance
         var result = calculator.Add(new int[]{1,2,3,4});
        and it is soooooo long.
        So, we can write method in different way to make it simple
         */
        /*step 3*/
        public void Add(params int[] numbers) { } /* this method is good*/

        /*now we can call method like this
         * var result = calculator.Add(1,2,3,4); 
         */
        /****************************************************************************************************************************/

    }
}
