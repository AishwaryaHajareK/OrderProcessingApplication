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
            switch(processsType.ToLower())
            {
                case "activate membership":
                    return new ActivateMembership();
                case "book":
                    return new Book();
                case "email owner":
                    return new EmailActivationOrUpgradeMembershipToOwner();
                case "physical product":
                    return new PhysicalProduct();
                case "upgrade to membership":
                    return new UpgradeToMembership();
                case "video":
                    return new Video();
                default:
                    return null;
            }
        }
    }
}
