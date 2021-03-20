using DesignPattern_FinalCaseStudy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyObserverPattern
{
    class AdminObserver : INotificationObserver
    {
        
        public string Name { get { return "Admin"; } }
        public int noOfTickets;
        public string eventInformation;
        public int NoOfTickets { get { return noOfTickets; } set { this.noOfTickets = value; } }
        public string EventInformation { get { return eventInformation; } set { this.eventInformation = value; } }

        public AdminObserver(int noOfTickets,string eventInformation)
        {
            this.noOfTickets = noOfTickets;
            this.eventInformation = eventInformation;
        }

        public void OnNotified()
        {
            
            Console.WriteLine("Notification has been recieved for event "+eventInformation+" by "+Name+" with "+noOfTickets+" Tickets");
        }
    }
}
