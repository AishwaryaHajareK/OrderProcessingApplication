using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingAppFactoryImplementation.ConcreteClass;

namespace OrderProcessing.Test
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void ProcessOrderWithValidData()
        {
            //Arrange the data
            var type = "Video";

            //Perform the Action
            OrderProcessFactory selectType = new ConcreteOrderProcessFactory();
            var processType = selectType.GetOrderProcessType(type);
            var result = processType.Process();

            //Assert
            Assert.IsTrue(result.Length > 0, "Test case passed as some data has been returned by repository");
            Assert.IsFalse(result.Length == 0, "This means something has been written by respository");
        }

        [TestMethod]
        public void ProcessOrderWithInValidData()
        {
            //Arrange the data
            var type = "Video123";
            string result = string.Empty;
            //Perform the Action
            OrderProcessFactory selectType = new ConcreteOrderProcessFactory();
            var processType = selectType.GetOrderProcessType(type);
            if(processType != null)
            {
                result = processType.Process();
            }
            
            //Assert
            Assert.IsTrue(result.Length == 0, "Test case did not pass as the request type passed is incorrect");
        }
    }
}
