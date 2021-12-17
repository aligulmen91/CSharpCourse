using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1977, 1, 1));         
            Console.WriteLine(person.Age);
        }

    }



    public class Person
    {
        /*as we told before, informations should be private and we should only access them from outside with methods
          * and here, it is easier way to define methods. we dont need to define private variable, we dont need to create a lot of methods
          */
        /*
        in commandline go to debug folder and
       run the "ildasm 027properties.exe" it will show us the classes, methods, and properties
        */
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; } /* this is enough for creating Birthdate as private, and all methods should call with get and set. 
                                                         and if we don't want to change this value from outside we can put private set here and create another constructor to reach here*/
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            
            }
        }

     
      
    }
}
