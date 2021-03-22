using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_ChainOfResponsibility
{
    public abstract class ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public ILeaveRequestHandler(ILeaveRequestHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void HandleRequest(LeaveRequest leaveDetails);
    }

    public class Supervisor : ILeaveRequestHandler
    {
        public Supervisor(ILeaveRequestHandler nextHandler) : base(nextHandler)
        {

        }
        public override void HandleRequest(LeaveRequest leaveDetails)
        {
            if (leaveDetails.LeaveDays >= 1 && leaveDetails.LeaveDays <= 3)
                Console.WriteLine("Mr.{0} Your Leave has been Approved by Supervisor.", leaveDetails.EmployeeName);
            else
            {
                //nextHandler.HandleRequest(leaveDays);
                Console.WriteLine("Supervisor forwarded the request to next Handler.");
                nextHandler.HandleRequest(leaveDetails);
            }
        }
    }
    public class ProjectManager : ILeaveRequestHandler
    {
        public ProjectManager(ILeaveRequestHandler nextHandler) : base(nextHandler)
        {

        }
        public override void HandleRequest(LeaveRequest leaveDetails)
        {
            if (leaveDetails.LeaveDays > 3 && leaveDetails.LeaveDays <= 5)
                Console.WriteLine("Mr.{0} Your Leave has been Approved by ProjectManager.", leaveDetails.EmployeeName);
            else
            {
                Console.WriteLine("ProjectManager forwarded the request to next Handler.");
                nextHandler.HandleRequest(leaveDetails);
            }
        }
    }
    public class HR : ILeaveRequestHandler
    {
        public HR(ILeaveRequestHandler nextHandler) : base(nextHandler)
        {

        }
        public override void HandleRequest(LeaveRequest leaveDetails)
        {
            if (leaveDetails.LeaveDays <10)
                Console.WriteLine("Mr.{0} Your Leave has been Approved by HR.",leaveDetails.EmployeeName);
            else
            {
                Console.WriteLine("Mr.{0} Your Leave has been Rejected by HR.",leaveDetails.EmployeeName);
            }
        }
    }
}
