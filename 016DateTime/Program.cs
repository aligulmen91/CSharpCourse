using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var year = now.Year;
            var month = now.Month;
            var day = now.Day;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;
            Console.WriteLine("hour : " + hour );

            var threeDaysLater = now.AddDays(3);/*move the time of "now" one day later*/
            Console.WriteLine(threeDaysLater); 
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("dd-mm-yyyy"));



            /*TIMESPAN*/
            /* Creating timespan objects */

            var timeSpan = new TimeSpan(1, 2, 3); /*hour, minute, second*/
            /*or with more readable way*/
            var timeSpan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : " + duration);

            //properties
            Console.WriteLine("Minutes : " + timeSpan.Minutes); /*it is two, because of timespan object*/
            Console.WriteLine("Minutes : " + timeSpan.TotalMinutes); /*converts all the timespan to minutes 1 hour : 60 min, 1 second : 1/60 min*/

            //Add (Timespan is 01:02:03)
            Console.WriteLine("Add Example : " + timeSpan.Add(TimeSpan.FromMinutes(8))); /* 01:10:03*/
            Console.WriteLine("Add Example : " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            //ToString
            Console.WriteLine("ToString : " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:02:03"));
        }
    }
}
