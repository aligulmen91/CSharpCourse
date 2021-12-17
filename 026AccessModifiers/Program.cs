using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 Types of access modifiers
             Public 
            Private
            Protected
            Internal
            Protected Internal
            */

            /*it is about safety , about object-oriented programming
             for oop we have three points
            - Encapsulation / Informatin Hiding
            - Inheritance
            - Polymorphism
            */

            /* Encapsulation / Informatin Hiding */
            /*
             In a restaurant everyone responsible from the special things,
            waiteress not go to kitchen and tell the chef how to chop vegetables,
            or chef not taking orders from customers
            all roles responsible from their things.
            It is same for application. Classes do their job, we don't want other classes learn details from other classes.
             */

            /*
             Define fields as private
            Provide getter / setter methods as public
            Private fields should start with "_" and follow with camel case. for example _name
             */
            var person = new Person();
            //   person._datetime;  //it is not exist, because it is private, we can not reach from here, we should call it with an method
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());

        }
    }

    public class Person
    {
        private DateTime _birthdate; /* we define birthdate of person as private. because we don't want others reach this information from outside, it is possible only with methods inside this class*/
        
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate; // they can not call _birthdate from outside directly, because it is private, but with this method, we send birthdate outside.
        }

    }
}
