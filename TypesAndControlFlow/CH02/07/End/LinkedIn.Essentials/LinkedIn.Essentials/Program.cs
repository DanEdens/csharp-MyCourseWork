// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;
//Employee sw = new ShiftWorker
ShiftWorker sw = new ShiftWorker
{
    FirstName = "staff",
    LastName = "one",
    StartDate = new DateOnly(2014, 2, 17),
    ShiftStartTime = new TimeOnly(8, 30)
};


Console.WriteLine("=============Shift Worker=============");
bool payrollProcessed = sw.ProcessPayroll();
sw.Terminate(DateTime.Now);
bool active = sw.IsActive();
Console.WriteLine();

//Manager mgr = new Manager
Employee mgr = new Manager
{
    FirstName = "manager",
    LastName = "one",
    NumberOfDirectReports = 7
};

Console.WriteLine("=============Manager=============");
bool mgrPayrollProcessed = mgr.ProcessPayroll();
mgr.Terminate(DateTime.Now);
bool mgrActive = mgr.IsActive();
