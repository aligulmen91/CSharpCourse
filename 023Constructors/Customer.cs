using System.Collections.Generic;

namespace _023Constructors
{
    public class Customer //We can create more than one constructor
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
       
        public Customer()
        {
           Orders = new List<Order>();
        }
        
        /* Now, this is very very very important
         * We define orders in customer() to avoid of application crash. This is good
         * But this will work only for customer(). we should copy that line for all constructors.
         * this is one way. but not good way.
         * So we can go on like this ;
         * on other constructors, we can write " : this() " after constructor name
         * it means, when you start for constructor, first run the " () " constructor, which means "customer()"
         * and then continue for our constructor. In this way, if we have thousand of variable, we don't need to copy all of them
         * we simply write " : this()" and it will be ok for all
         * 
         */
        
        /*The other constructors are not needed, because it is not really really needed*/
        
        public Customer(int id)
            :this() /* please read the description */
        {
            this.Id = id;

        }
        public Customer(int id, string name)
            : this() /* please read the description */
        {
            this.Id= id; 
            this.Name = name;  
        }
     
    }
}
