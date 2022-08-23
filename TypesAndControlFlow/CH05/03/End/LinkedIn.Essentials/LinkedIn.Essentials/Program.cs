// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

ShiftWorker d = new ShiftWorker() { FirstName = "Dynamic", 
    LastName = "Worker" };
d.DaysAvailable = ShiftDays.Weekend;// | ShiftDays.Weekend;
bool availableMonday = d.DaysAvailable.HasFlag(ShiftDays.Monday);
Console.WriteLine($"Available Mondays {availableMonday}");

bool availableSaturdays = (d.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;
Console.WriteLine($"Available Saturdays {availableSaturdays}");

Console.WriteLine(d.DaysAvailable);

var shiftNames = System.Enum.GetNames(typeof(ShiftDays));
Console.WriteLine(String.Join(',', shiftNames));

var shiftValues = (short[])System.Enum.GetValues(typeof(ShiftDays));
Console.WriteLine(String.Join(',', shiftValues));

var day = DayOfWeek.Monday;
//Console.WriteLine(day);
var shiftDay = ShiftDays.Tuesday;
//Console.WriteLine((int)shiftDay);
