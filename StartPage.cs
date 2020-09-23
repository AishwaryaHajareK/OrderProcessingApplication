using OrderProcessingAppFactoryImplementation.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApplication
{
    class StartPage
    {
        static void Main(string[] args)
        {
            OrderProcessFactory orderProcess = new ConcreteOrderProcessFactory();
            Console.WriteLine("Enter the request you want to process. Following is the list of request. You can Select the one to process");
            Console.WriteLine("\nActivate membership");
            Console.WriteLine("Book");
            Console.WriteLine("Email Owner");
            Console.WriteLine("Physical Product");
            Console.WriteLine("Upgrade To Membership");
            Console.WriteLine("Video\n");
            
            var type = Console.ReadLine();

            var paymetRequest = orderProcess.GetOrderProcessType(type);
            paymetRequest.Process();

            Console.ReadKey();
        }
    }
}
