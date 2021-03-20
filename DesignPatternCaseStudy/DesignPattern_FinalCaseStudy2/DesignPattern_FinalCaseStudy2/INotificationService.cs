using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FinalCaseStudy2
{
    public interface INotificationService
    {
       void AddEvent(INotificationObserver observer);
       void NotifyAdmin();
    }
}
