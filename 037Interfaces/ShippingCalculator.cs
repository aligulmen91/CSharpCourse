namespace _037Interfaces
{

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}
/*When we are preparing tests, we check one by one, first look at OrderProcessor
 We have two statement order.IsShipped, or !order.IsShipped, and the problem, we should isolate every classes to test them
everything should work properly. so, we get right results
But inside orderProcessor, we have tight coupling with ShippingCalculator. it is depended with this. so, we should isolate it
to solve this, we use interface

if we change any code inside shippingcalculator, now it wont affect the other codes
*/