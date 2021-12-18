namespace _031SecondPillarofOOPInheritance /*we changed this to amazon*/
{
    public class RateCalculator
    {
        public int Calculate(Customer customer)
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