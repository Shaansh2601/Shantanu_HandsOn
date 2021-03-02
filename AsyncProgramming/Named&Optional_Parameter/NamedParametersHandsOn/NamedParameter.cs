using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParametersHandsOn
{
    class NamedParameter
    {
        public void GetCohortDetails(string c_name,int genc_count,string mode,string track,string curr_module)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}",c_name,genc_count,track,mode,curr_module);
        }
        static void Main(string[] args)
        {
            NamedParameter p = new NamedParameter();
            p.GetCohortDetails("ADM20DF003", 21, "OBL", ".Net", "Advance C#");
            p.GetCohortDetails(".Net", 21, "OBL", "ADM20DF003", "Advance C#");
            p.GetCohortDetails(track:".Net",mode:"OBL",c_name:"ADM20DF003",curr_module:"Advance C#",genc_count:21);

            OptionalParameter op = new OptionalParameter();
            op.OrderDetails("Flipkart", "Samsung Mobile");
            op.OrderDetails("Flipkart", "Samsung Mobile",3,false);
            Console.ReadLine();
        }
    }
}
