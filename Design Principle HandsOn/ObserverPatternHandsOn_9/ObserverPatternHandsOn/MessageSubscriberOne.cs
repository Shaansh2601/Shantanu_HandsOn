using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandsOn
{
    class MessageSubscriberOne:Observer
    {
        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());

        }
    }
    class MessageSubscriberTwo : Observer

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());

        }

    }


    class MessageSubscriberThree : Observer

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());

        }

    }
}
