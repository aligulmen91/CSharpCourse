using System;

namespace _006Classes
{
    /*
        Class : Person
        Fields : Name, Age, Height, Weight
        Methods : Walk, talk, eat, sleep
        objects : John, Mary, Scott
     */

    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name + " and i'm " + Age + " years old!");
        }

    }

}