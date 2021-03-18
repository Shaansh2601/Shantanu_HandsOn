using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHandsOn
{
    interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(IUser user, string message);
    }
}
