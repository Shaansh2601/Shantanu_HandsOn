using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParametersHandsOn
{
    class OptionalParameter
    {
        public void OrderDetails(string sellerName,string prodName,int quantity=1,bool isReturnable=true)
        {
            Console.WriteLine("Here is the order detail – {0} number of {1} by {2} is ordered. It’s returnable status is {3}", quantity, prodName, sellerName, isReturnable);
        }
    }
}
