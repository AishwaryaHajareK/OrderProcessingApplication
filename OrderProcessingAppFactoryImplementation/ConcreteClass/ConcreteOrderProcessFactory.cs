using OrderProcessingAppFactoryImplementation.Interface;
using OrderProcessingAppFactoryImplementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppFactoryImplementation.ConcreteClass
{
    public class ConcreteOrderProcessFactory : OrderProcessFactory
    {
        public override IOrderProcessing GetOrderProcessType(string processsType)
        {
            switch(processsType)
            {
                case "ActivateMembership":
                    return new ActivateMembership();
                case "Book":
                    return new Book();
                case "EmailActivationOrUpgradeMembershipToOwner":
                    return new EmailActivationOrUpgradeMembershipToOwner();
                case "PhysicalProduct":
                    return new PhysicalProduct();
                case "UpgradeToMembership":
                    return new UpgradeToMembership();
                case "Video":
                    return new Video();
                default:
                    throw new ApplicationException(string.Format("Nothing to process"));
            }
        }
    }
}
