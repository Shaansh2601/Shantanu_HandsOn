using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy2
{
    public interface INotificationObserver
    {
        string Name { get; }

        int NoOfTickets { get; set; }
        string EventInformation { get; set; }
        void OnNotified();
    }
}
