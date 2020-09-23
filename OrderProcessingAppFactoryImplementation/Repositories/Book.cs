using OrderProcessingAppFactoryImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.Repositories
{
    public class Book : IOrderProcessing
    {
        public string Process()
        {
            var msg = "Inside the Book class to process";
            //Write the repository logic to process the request for Book
            Console.WriteLine(msg);
            return msg;
        }
    }
}
