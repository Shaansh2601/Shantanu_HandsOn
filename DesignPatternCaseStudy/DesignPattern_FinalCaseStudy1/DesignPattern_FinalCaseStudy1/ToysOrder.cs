using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public class ToysOrder : Order
    {
        public ToysOrder(Product_Type ProductType,Channel channel) : base(Product_Type.Toys, channel) 
        {
            processOrder();
        }
        public override void processOrder()
        {

            Console.WriteLine("The ordered product is Toys");

            Console.WriteLine(base.ToString());
        }
    }
}
