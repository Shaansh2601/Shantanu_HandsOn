using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHandsOn
{
    interface ILeaveRequestHandler
    {
        ILeaveRequestHandler NextHandler { get; set; }

        void HandleRequest(LeaveRequest obj);
    }
}
