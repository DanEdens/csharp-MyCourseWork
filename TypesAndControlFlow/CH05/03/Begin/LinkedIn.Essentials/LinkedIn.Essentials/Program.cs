// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

ShiftWorker d = new ShiftWorker() { FirstName = "Dynamic", 
    LastName = "Worker" };
d.DaysAvailable = ShiftDays.Weekdays | ShiftDays.Weekend;


Console.WriteLine(d.DaysAvailable);

var day = DayOfWeek.Monday;
//Console.WriteLine(day);
var shiftDay = ShiftDays.Tuesday;
//Console.WriteLine((int)shiftDay);
