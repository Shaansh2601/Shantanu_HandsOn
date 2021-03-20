using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy1
{
    public enum Product_Type
    {
        Electronic_Products,
        Toys,
        Furniture
    }
    public enum Channel
    {
        E_CommerceWebsite,
        TeleCallerAgentsApplication
    }
    public abstract class Order
    {
        
        public Order(Product_Type ProductType,Channel Channel)
        {
            this.ProductType = ProductType;
            this.Channel=Channel;
        }
        public abstract void processOrder();

        public Product_Type ProductType { get; set; }
        public Channel Channel { get; set; }

        public override string ToString()
        {
            return ProductType+"  accepted by  "+Channel;
        }


    }
}
