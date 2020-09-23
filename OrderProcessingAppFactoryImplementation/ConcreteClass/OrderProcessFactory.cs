using OrderProcessingAppFactoryImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.ConcreteClass
{
    public abstract class OrderProcessFactory
    {
        public abstract IOrderProcessing GetOrderProcessType(string Vehicle);
    }
}
