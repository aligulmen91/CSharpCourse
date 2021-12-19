using System;

namespace _037Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process (Order order)
        {
            if (order.IsShipped)
            throw new InvalidOperationException("This order is already processed!");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}

/*When we are preparing tests, we check one by one, first look at OrderProcessor
 We have two statement order.IsShipped, or !order.IsShipped, and the problem, we should isolate every classes to test them
everything should work properly. so, we get right results
But inside orderProcessor, we have tight coupling with ShippingCalculator. it is depended with this. so, we should isolate it
to solve this, we use interface
And we connect not to classes, to interfaces
*/