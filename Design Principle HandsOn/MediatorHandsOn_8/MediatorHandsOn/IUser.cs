using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHandsOn
{
    interface IUser
    {
        string Name { get; set; }
        void RecieveMesage(IUser u, string message);
        void SendMesage(string message);
    }
}
