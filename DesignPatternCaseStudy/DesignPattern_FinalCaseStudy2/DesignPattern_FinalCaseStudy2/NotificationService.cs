using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy2
{
    public class NotificationService: INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();

        public void AddEvent(INotificationObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine(observer.EventInformation+ " is added\n\nList of Subscribers");
            foreach(var ob in observers)
            {
                Console.WriteLine(ob.EventInformation);
            }
        }

        public void NotifyAdmin()
        {
            foreach (var ob in observers)
            {
                if(ob.NoOfTickets>100)
                {
                    ob.OnNotified();
                }
                
            }

        }
    }
}
