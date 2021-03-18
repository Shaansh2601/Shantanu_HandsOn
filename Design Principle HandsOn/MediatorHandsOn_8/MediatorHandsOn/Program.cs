using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();
            IUser user1 = new PremiumUser() { Name = "PreUser1" };
            IUser user2 = new PremiumUser() { Name = "PreUser2" };
            IUser user3 = new BasicUser() { Name = "BasicUser1" };
            IUser user4 = new BasicUser() { Name = "BasicUser2" };
            chat.AddUser(user1);
            chat.AddUser(user2);
            chat.AddUser(user3);
            chat.AddUser(user4);


            IUser sender = new PremiumUser() { Name = "Sender" };
            chat.SendMessage(sender, "Good Morning");
            Console.ReadLine();
        }
    }
}
