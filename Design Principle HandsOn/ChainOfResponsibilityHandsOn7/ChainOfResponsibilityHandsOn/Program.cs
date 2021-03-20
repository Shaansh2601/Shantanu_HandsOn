using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest obj = new LeaveRequest() { LeaveDays = 1, Employee = "Emp1" };
            LeaveRequest obj2 = new LeaveRequest() { LeaveDays = 5, Employee = "Emp2" };
            LeaveRequest obj3 = new LeaveRequest() { LeaveDays = 8, Employee = "Emp3" };
            ILeaveRequestHandler leave = new Supervisor();
            Console.WriteLine("Requesting leaves for 1 day\n");
            leave.HandleRequest(obj);

            Console.WriteLine("\nRequesting leaves for 5 day\n");
            leave.HandleRequest(obj2);

            Console.WriteLine("\nRequesting leaves for 8 day\n");
            leave.HandleRequest(obj3);

            Console.ReadLine();
        }
    }
}
