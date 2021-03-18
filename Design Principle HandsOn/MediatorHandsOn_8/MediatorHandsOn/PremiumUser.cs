using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHandsOn
{
    class PremiumUser:IUser
    {
        public string Name { get; set; }

        ChatMediator chat = new ChatMediator();

        public void RecieveMesage(IUser u, string message)
        {
            Console.WriteLine(message + " received by " + Name);
        }

        public void SendMesage(string message)
        {
            chat.SendMessage(this, message);
        }
    }
}
