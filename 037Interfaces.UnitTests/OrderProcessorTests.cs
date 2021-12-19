using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _037Interfaces.UnitTests
{

    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
        };
            orderProcessor.Process(order);
            
        }


        /*Second Test*/
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order(); /*we dont define shipment because we want to test if there is no shipment property*/
            orderProcessor.Process(order);

            /*with assert, we define which results we are waiting after the test, we will define one by one*/
            Assert.IsTrue(order.IsShipped); /*Lets be sure if is shipped being true*/
            Assert.AreEqual(1, order.Shipment.Cost); /*In fake shipping calculator, we define cost 1, so we expect to return 1*/
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }










        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
/*When we are preparing tests, we check one by one, first look at OrderProcessor
 We have two statement order.IsShipped, or !order.IsShipped, and the problem, we should isolate every classes to test them
everything should work properly. so, we get right results
But inside orderProcessor, we have tight coupling with ShippingCalculator. it is depended with this. so, we should isolate it
to solve this, we use interface
*/


/*Test > RUN ALL TEST*/