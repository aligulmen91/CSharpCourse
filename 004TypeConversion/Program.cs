using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            /*Implicit Type Conversion*/
            byte b = 0;                         /*  00000001  */   
            int i = b;                          /* 00000000 00000000 00000000 00000001  data will not loose, it is safe  */
            float f = i;                        /* data will remain same, so it is safe */

            /*Explicit Type Conversion*/
            int x = 1;
            //  byte y = i;                         /* won't compile, because 3 or 4 bytes will be gone and we may loose data */
            byte y = (byte)i;                       /* we tell the compiler that we are aware of loosing data, we will do it anyway */

            float z = 1.0f;
            int t = (int)f;

            /*Non-Compatible Type Conversion*/
            string s = "1";
            // int j = (int)s;                        /*won't compile, because it is non-compatible type conversion*/
            int k = Convert.ToInt32(s);
            int l = int.Parse(s);



            /* If we try to convert a number bigger than the max value of a type the application will be crashed. To avoid application crashing, we should use try catch. */
            try                                     /* Write try and press tab twice, it is a code snippet */
            {
                var number = "1234";                    /* we define string with var variable */
                byte bTwo = Convert.ToByte(number);      /* force to convert number to byte, but it will give an error, because byte can contain max. 255. , so we should use try catch */
                Console.WriteLine(bTwo);
            }
            catch (Exception)
            {
                Console.WriteLine("The number couldn't be converted to a byte.");
            }

           
        }
    }
}
