using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  DateTime date = null; //it won't compile, because date time can not be null but we can write like this..
            Nullable<DateTime> date = null; //sometimes customers don't want to write birthdate
            DateTime? birthdate = null;

            Console.WriteLine("GetValueOrDefault : " + date.GetValueOrDefault());
            Console.WriteLine("HasValue : " + date.HasValue);


            //Console.WriteLine("Value : " + date.Value); /this wont work because we don't have value, use GetValueOrDefault

            DateTime? date2 = new DateTime(2014, 1, 2);
            DateTime date3 = date2.GetValueOrDefault();
            Console.WriteLine(date3);

            DateTime? date4 = null;
            DateTime date5;

            
            if (date4 != null)
                date5 = date.GetValueOrDefault();
            else 
                date5 = DateTime.Today;

            /*we can write shorter*/
            DateTime? date6 = null;
            DateTime date7 = date6 ?? DateTime.Today; // if date6 has value put it to date7, else put datetime.Today  or
            DateTime date8 = (date !=null) ? date.GetValueOrDefault() : DateTime.Today;

        }
    }
}


/*
 Boolean can not be null
Customers.Birthdate(datetime NULL) // Nullable type
 
 
 */