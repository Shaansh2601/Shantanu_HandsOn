using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHandsOn
{
    class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }

        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 7)
                Console.WriteLine("Leave approved by ProjectManager");
            else
            {
                NextHandler = new HR();
                NextHandler.HandleRequest(obj);

            }
        }
    }
}
