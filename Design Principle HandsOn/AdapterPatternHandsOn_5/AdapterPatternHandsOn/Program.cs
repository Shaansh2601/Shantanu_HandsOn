using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            BugattiVeyron bugattiVeyron = new BugattiVeyron();
            

            Console.WriteLine("Buggati Price in USD "+bugattiVeyron.getPrice());

            PriceAdapter priceAdapter = new PriceAdapterUsdToEuro(bugattiVeyron);
            Console.WriteLine("Buggati Price in EURO " + priceAdapter.getPrice());

            Console.ReadLine();
        }
    }
}
