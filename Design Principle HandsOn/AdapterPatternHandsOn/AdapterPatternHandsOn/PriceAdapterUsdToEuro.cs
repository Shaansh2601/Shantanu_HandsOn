using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternHandsOn
{
    class PriceAdapterUsdToEuro:PriceAdapter
    {
        private Price luxuryCars;
        public PriceAdapterUsdToEuro(Price price)
        {
            luxuryCars = price;
        }

        public double getPrice()
        {
            return convertUSDtoEURO(luxuryCars.getPrice());
        }
        private double convertUSDtoEURO(double usd) { return usd * 0.84; }
    }
}
