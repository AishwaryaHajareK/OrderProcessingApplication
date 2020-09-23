using OrderProcessingAppFactoryImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.Repositories
{
    public class UpgradeToMembership : IOrderProcessing
    {
        public void Process()
        {
            //Write the repository logic to process the request for UpgradeToMembership
            Console.WriteLine("Inside the UpgradeToMembership class to process.");
        }
    }
}
