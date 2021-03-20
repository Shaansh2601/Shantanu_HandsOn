using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public interface OrderFactory
    {
        void makeElectronics(Product_Type product, Channel channel);
        void makeToys(Product_Type product, Channel channel);
        void makeFurniture(Product_Type product, Channel channel);
    }
}
