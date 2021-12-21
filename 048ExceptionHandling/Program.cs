using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048ExceptionHandling
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Sorry, an unexpected error eccoured by dividing zero");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Sorry, an unexpected error eccoured by arithmetic exceptions");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error eccoured in the system");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                //Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.TargetSite);
            }

            finally
            {
                //file handlers, database connections, network connections etc. we need to manually clean up here.
                //IDisposable  press F12 to see more information

            }





            /*another example with finally*/
            var streamReader = new StreamReader(@"C:\file.zip");
            try
            {
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {

                Console.WriteLine("Sorry, an unexpected error occurred.") ;
            }
            finally 
            {
                if (streamReader != null)
                streamReader.Dispose(); //this block always work at the end
            }





            /*same example with more easy way*/
            try
            {
                using (var streamReader2 = new StreamReader(@"C:\file.zip")) //this will automatically call finally block and close file at the and, we dont need to care about it with finally block
                {
                    var content = streamReader2.ReadToEnd();
                }
                   
            }
            catch (Exception)
            {

                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
           







        }

    }
}
/*
 try catch blocks can be used multiple but it should be from most spesific to most generic
first check spesific things, if they are ok, check general things. in this way, application will give message on the right place
 
 */