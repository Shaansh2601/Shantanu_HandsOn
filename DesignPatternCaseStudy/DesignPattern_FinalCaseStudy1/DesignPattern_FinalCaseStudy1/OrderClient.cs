using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public class OrderClient
    {
        OrderFactory orderFactory;

        public OrderClient(OrderFactory orderFactory)
        {
            this.orderFactory = orderFactory;
        }

        public void BuildElectronics(Channel channel)
        {
            orderFactory.makeElectronics(Product_Type.Electronic_Products, channel);
        }
        public void BuildToys(Channel channel)
        {
            orderFactory.makeToys(Product_Type.Toys, channel);
        }
        public void BuildFurniture(Channel channel)
        {
            orderFactory.makeFurniture(Product_Type.Furniture, channel);
        }

    }
}
