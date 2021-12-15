using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Enums
{
    internal class Program
    {
        /*You can create enums without assigning numbers. But in the future, if you add new options, and if the order change, it will cause a huge issue. So, alyways give numbers*/
        public enum ShippingMethod
        {
            RegularAirMail =1,
            RegisteredAirMail =2,
            Express =3,
        }
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express; //We have an shipping with express method
            Console.WriteLine(method);
            Console.WriteLine((int)method);
            /*or if we want to change id to message.. */
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            /*This is important, if we don't write .ToString() it will still show the result to us. But it is because of Console.Writeline method.
             If we want to use method as a string inside the software in another place, we have to say method.ToString()*/
            Console.WriteLine(method.ToString());

            /*From string to enum type*/
            var methodName = "Express";
            var shippingMethod =(ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
