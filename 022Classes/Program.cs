using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022Classes
{
    /*
             * Real World Applications
             * Presentation
             * Business Logic / Domain Layer 
             * Data Access / Persistence Layer
             * 
             * We have a classes inside each layer
             */

    /* Anatomy of a Class
     * Data (represented by fields)
     * Behaviour (represented by methods / functions)
     */

    /* Object
     * An instance of a class
     * Class : Person,  Object : Ahmet, Mehmet, Mustafa
     * 
     * Instance Objects :
     * var person = new Person(;
     * 
     * Static Objects : accesiable from the class
     * console.WriteLine(); // no need to create new instance
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ahmet= new Person();  
            var mehmet = new Person();
            ahmet.Name = "Ahmet Gulmen";
            ahmet.Introduce("Semih");

            
           var p  = Person.Parse("mustafa"); /*we can create instance from string*/
            p.Introduce("John");
        }
    }

    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is : {1}" ,to, Name);
        }

        /*if you want to create an istance from string, you can use it in this way.*/
        public static Person Parse(string str)
        {
            var person = new Person();  
            person.Name = str;
            return person;
        }
    }
}
