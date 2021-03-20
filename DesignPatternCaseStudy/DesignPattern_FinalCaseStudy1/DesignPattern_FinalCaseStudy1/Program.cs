using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderFactory orderFactory = new ConcreteOrderFactory();
            OrderClient orderClient = new OrderClient(orderFactory);

            orderClient.BuildElectronics(Channel.E_CommerceWebsite);
            orderClient.BuildFurniture(Channel.E_CommerceWebsite);
            orderClient.BuildToys(Channel.TeleCallerAgentsApplication);

            Console.ReadLine();


        }
    }
}
