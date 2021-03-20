using PracticeCaseStudyObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy2
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminObserver event1 = new AdminObserver(101,"Event 1");
            AdminObserver event2 = new AdminObserver(70, "Event 2");
            AdminObserver event3 = new AdminObserver(120, "Event 3");
            AdminObserver event4 = new AdminObserver(22, "Event 4");


            NotificationService service = new NotificationService();
            service.AddEvent(event1);
            service.AddEvent(event2);
            service.AddEvent(event3);
            service.AddEvent(event4);
            service.NotifyAdmin();

            Console.ReadLine();
        }
    }
}
