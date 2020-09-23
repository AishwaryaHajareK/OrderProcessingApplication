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
        public string Process()
        {
            var msg = "Inside the Active Membership class to process.";
            //Write the repository logic to process the request for ActiveMembership
            Console.WriteLine(msg);
            return msg;
        }
    }
}
