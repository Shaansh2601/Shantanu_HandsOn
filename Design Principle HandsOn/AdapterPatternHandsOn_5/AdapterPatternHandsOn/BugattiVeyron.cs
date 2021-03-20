using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternHandsOn
{
    class BugattiVeyron :Price
    {
        public double getPrice()
        {
            return 2555;
        }

    }
}
