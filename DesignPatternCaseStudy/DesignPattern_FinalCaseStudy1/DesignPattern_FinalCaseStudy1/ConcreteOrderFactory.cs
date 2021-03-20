using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    class ConcreteOrderFactory : OrderFactory
    {
        public void makeElectronics(Product_Type product, Channel channel)
        {
            new ElectronicOrder(Product_Type.Electronic_Products, channel);
        }

        public void makeFurniture(Product_Type product, Channel channel)
        {
            new FurnitureOrder(Product_Type.Furniture, channel);
        }

        public void makeToys(Product_Type product, Channel channel)
        {
            new ToysOrder(Product_Type.Toys, channel);
        }
    }
}
