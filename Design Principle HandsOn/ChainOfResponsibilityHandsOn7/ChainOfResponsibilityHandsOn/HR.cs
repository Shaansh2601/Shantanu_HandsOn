using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHandsOn
{
    class HR : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;
        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }


        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 10)
            {
                Console.WriteLine("Leaves approved by HR");
            }
            else
            {
                Console.WriteLine("Leaves rejected by HR");

            }
        }
    }
}
