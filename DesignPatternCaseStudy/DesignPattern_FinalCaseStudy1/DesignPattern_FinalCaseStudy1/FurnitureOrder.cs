using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(Product_Type ProductType, Channel channel) : base(Product_Type.Furniture, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("The ordered product is Furniture");

            Console.WriteLine(base.ToString());
        }
    }
}
