using OrderProcessingAppFactoryImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.Repositories
{
    public class PhysicalProduct : IOrderProcessing
    {
        public string Process()
        {
            var msg = "Inside the PhysicalProduct class to process";
            //Write the repository logic to process the request for PhysicalProduct
            Console.WriteLine(msg);
            return msg;
        }
    }
}
