using OrderProcessingAppFactoryImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.Repositories
{
    public class ActivateMembership : IOrderProcessing
    {
        public void Process()
        {
            //Write the repository logic to process the request for ActiveMembership
            Console.WriteLine("Inside the Active Membership class to process.");
        }
    }
}
