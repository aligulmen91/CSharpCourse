using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032ConstructorNInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("34AAG345");
        }
    }

    public class Veichle
    {
        /*lets explain here,
         * _registrationNumber is private string, it means we can reach it only inside this class
         in other classes we use Veichle() and we should reach this private string but how?
         well, we create new string named "registrationNumber" on the other classes they enter this string
         and inside this class we take that string as a private string, simple uh? */
        private string _registrationNumber;

        public Veichle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Veichle is being initialized with : {0}", registrationNumber);
        }

    }

    public class Car : Veichle
    {
        /*this is derived class, which means it can use all spesifications of veichle, because car is a veichle...*/
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            /*As we used for all veichles, in cars we also have registrationNumber and we want to use it
             but _registrationNumber was private and we can not reach it from other classes?!??! ok, for this, we have "base"
             it means, we take base base(registrationNumber) this. so, we don't need to try to reach private string again.*/
            Console.WriteLine("Car is being initialized with : {0}",registrationNumber);
        }
    } 
}
