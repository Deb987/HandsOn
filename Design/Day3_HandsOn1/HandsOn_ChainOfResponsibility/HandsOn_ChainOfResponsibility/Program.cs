using System;

namespace HandsOn_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leaveDetails = new LeaveRequest() { EmployeeName = "ABC", LeaveDays = 2 };

            HR hr = new HR(null);
            ProjectManager projectManager = new ProjectManager(hr);
            Supervisor supervisor = new Supervisor(projectManager);

            supervisor.HandleRequest(leaveDetails);

            Console.ReadLine();
        }
    }
}
