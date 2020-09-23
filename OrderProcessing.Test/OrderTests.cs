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
            processType.Process();

            //Assert

        }
    }
}
