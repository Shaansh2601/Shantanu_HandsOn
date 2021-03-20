using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHandsOn
{
    class Supervisor : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;
        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }


        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 3)
                Console.WriteLine("Leave approved by SuperVisor");
            else
            {
                NextHandler = new ProjectManager();
                NextHandler.HandleRequest(obj);

            }
        }
    }
}
