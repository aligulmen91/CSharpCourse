using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}

/*instead of using class keyword, we use interface keyword
 it always start with 'I'
we use it to build loosely-coupled applications
because interfaces are don't have code, it is just decoration

 
 public interface ITaxCalculator {
int Calculate(); 
}


 */
/*When we are preparing tests, we check one by one, first look at OrderProcessor
 We have two statement order.IsShipped, or !order.IsShipped, and the problem, we should isolate every classes to test them
everything should work properly. so, we get right results
But inside orderProcessor, we have tight coupling with ShippingCalculator. it is depended with this. so, we should isolate it
to solve this, we use interface

And in main program we can use directly class, not interface, because this is main, this knows about everything. 
*/