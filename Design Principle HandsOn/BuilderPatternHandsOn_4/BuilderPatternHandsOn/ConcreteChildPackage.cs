using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHandsOn
{
    class ConcreteChildPackage:Builder
    {
        Product p = new Product();
        public void BuildSavories()
        {
            p.Add("1 Savory");
        }

        public void BuildSweet()
        {
            p.Add("2 Sweets");
        }

        public Product GetResults()
        {
            return p;
        }
    }
}
