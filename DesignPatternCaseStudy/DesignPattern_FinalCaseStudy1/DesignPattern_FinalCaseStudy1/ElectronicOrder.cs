using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public class ElectronicOrder : Order
    {
        public ElectronicOrder(Product_Type ProductType, Channel channel) : base(Product_Type.Electronic_Products, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("The ordered product is Electronics");

            Console.WriteLine(base.ToString());

        }
    }
}
