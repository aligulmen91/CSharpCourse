using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Classes
{

    /*
     It will be a lot of classes in the future,
so we should create seperate files for each classes
you can create a cs file with the name of class or
you can click on the class, and from the left menu click "move to 'Person.cs'" option
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); /* when you create an object, "class objectname = new class" you should define that you are creating new object*/
           
            /*or you can create an object with "var" in easier way*/
            var mehmet = new Person();
            mehmet.Name = "Mehmet";
            mehmet.Age = 42;
            mehmet.Introduce();

        int result = Calculator.Add(1, 2); /*if it was not static, we ought to create object first!!!! Calculator calculator = new Calculator()*/
            Console.WriteLine(result); /* Console is also a STATIC VOID CLASS, so, we don't create object everytime, and it doesn't return anything for us */
        }
    }

}