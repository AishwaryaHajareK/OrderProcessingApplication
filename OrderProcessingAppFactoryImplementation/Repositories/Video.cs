using OrderProcessingAppFactoryImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.Repositories
{
    public class Video : IOrderProcessing
    {
        public void Process()
        {
            //Write the repository logic to process the request for Video
            Console.WriteLine("Inside the Video class to process.");
        }
    }
}
