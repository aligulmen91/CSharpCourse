using System;

namespace _031SecondPillarofOOPInheritance /*we changed this to amazon*/
{

    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public Customer()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
           var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

                Console.WriteLine("Promoted to Level 2");
        }

        private int CalculateRating() /* this method we use inside our class. we dont need to reach from outside
                                        if we leave this as a public, and if someone use in another class, later when we change
                                        some coding from here, we will get a bunch of error. 
                                        so, we should touch all the application for little implementation.
                                        so, we are going to use as private
                                      */
        {
            return 0;
        }

        protected int RatingSituation(bool excludeOrders)
        {
            return 0;
        }
    }
}


/*We design the objects like a Black-Box to isolating changes*/

/*
 Public : accessible from everywhere
public class Customer
{
    public void Promote()
        {
        ....
        }
}


....

var customer = new Customer();
customer.Promote();             //it is accesible


________________________________________________________

private : Accesible only from the class.if we change any parameter, anything inside it, we don't need to
touch any other place on application

public class Customer
{
    private int CalculateRating()
        {
        ....
        }
}


....

var customer = new Customer();
//we can not access CalculateRating here.

________________________________________________________

Protected : Accessible only from the class and its derived classes
it is similar with private, but for example for the customer, lets derived goldCustomer. we can reach
from here . this is the difference between private and protected. But this brake encapsulation, because 
if we change anything it will affect other classes.
avoid if you can and use private, but if you really need to use it be aware of you affect others



________________________________________________________

Internal : Accessible only from the same assembly, we usually use with classes not members

internal class RateCalculator
{

}
...

//In the same assembly
var calc = new RateCalculator(); //we can use here, in another assembly not possible
________________________________________________________

Protected Internal : Accesible only from the same assebmly or any derived classes, do not use

 */