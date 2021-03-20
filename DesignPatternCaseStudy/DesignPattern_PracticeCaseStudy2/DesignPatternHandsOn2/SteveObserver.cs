using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyObserverPattern
{
    class SteveObserver : INotificationObserver
    {
       
        public string Name { get { return "Steve"; } }

        public void OnServerDown()
        {
            
            Console.WriteLine("Notification has been recieved by " + Name);
        }
    }
}
