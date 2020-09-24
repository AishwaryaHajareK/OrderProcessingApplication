using OrderProcessingAppFactoryImplementation.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApplication
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            OrderProcessFactory orderProcess = new ConcreteOrderProcessFactory();
            int flag = -1;
            Console.WriteLine("Enter the request you want to process. Following is the list of request:");
            do
            {
                Console.WriteLine("\nActivate membership");
                Console.WriteLine("Book");
                Console.WriteLine("Email Owner");
                Console.WriteLine("Physical Product");
                Console.WriteLine("Upgrade To Membership");
                Console.WriteLine("Video\n");

                var type = Console.ReadLine();

                var paymetRequest = orderProcess.GetOrderProcessType(type);
                if(paymetRequest != null)
                {
                    paymetRequest.Process();

                    Console.WriteLine("\n\nPress 1 to continue else press 0 to stop.");
                    flag = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The request you selected is incorrect.\nPlease select the correct option.");
                    flag = 1;
                }
            }
            while (flag == 1);
            
            Console.ReadKey();
        }
    }
}
