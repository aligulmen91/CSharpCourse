using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023Constructors
{

    /*
     * ctor + TAB is code snippet for constructor!
     * CTRL K + CTRL C make comment 
     * 
     * Constructors has same name with the class ! it is void... 
     * If we need to create an object upon creation, we use constructors
     * It creates objects for us while creation
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*If we don't create constructor and try to check what we have in customer.Id and customer.Name, we will see that id:0 and Name:NULL*/
            //    var customer = new Customer();
            //    Console.WriteLine(customer.Id);
            //    Console.WriteLine(customer.Name);

            /* because of we create constructors as customer(int id) and customer(int id,string name)
             * now developer can not create object without defining id or id and name like Customer().
             * If you want anyway to use without any variable, you should create another constructor without any parameter
             * 
             * But using with parameters not good while creation. We should do if it is really really really important
             * for example, we can define id and name later. it is not end of the world.
             * but sometimes we need cases to create at first
             * for example orders we are creating list in Customer class. And whenever we create new customer, orders should have empty list, so, we should define it inside constructors
             * if we don't create it on creation, the application will crash. nullreference exception
             * so, we should use constructor to create that list with empty at first (id not needed, name not needed)
             */

            /*Now we have 3 constructor and 3 different way to create customers*/
            var customer1 = new Customer();
            customer1.Id = 10;
            customer1.Name = "Ahmet";
            var order = new Order();
            customer1.Orders.Add(order);
            
            var customer2 = new Customer(1);
            customer2.Name = "Mehmet";
            
            var customer3 = new Customer(2,"John"); 


            Console.WriteLine("First Customer : ");    
            Console.Write("{0} {1} \n", customer1.Id, customer1.Name);
            Console.WriteLine("Second Customer : ");
            Console.Write("{0} {1} \n", customer2.Id, customer2.Name);
            Console.WriteLine("Third Customer : ");
            Console.Write("{0} {1} \n", customer3.Id, customer3.Name);
        }
    }
    /* Customer class in another file customer.cs */

    /* Order class in another file Order.cs */

}
