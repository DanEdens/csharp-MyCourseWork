// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "something";
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

//Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 15, 'x'));

//var shiftDay = GetShiftDays((DayOfWeek)17);
//Console.WriteLine(shiftDay);

static ShiftDays GetShiftDays(DayOfWeek day) => day switch
{
    DayOfWeek.Monday  => ShiftDays.Monday,
    DayOfWeek.Tuesday => ShiftDays.Tuesday,
    DayOfWeek.Wednesday => ShiftDays.Wednesday,
    DayOfWeek.Thursday => ShiftDays.Thursday,
    DayOfWeek.Friday => ShiftDays.Friday,
    DayOfWeek.Saturday => ShiftDays.Saturday,
    DayOfWeek.Sunday => ShiftDays.Sunday,
    _ => throw new ArgumentException("Invalid day of week suppliied")

};

var shiftDate = new DateTime(2022, 1, 2, 16, 0, 0);
Console.WriteLine($"Shift {(IsWeekendNightShift(shiftDate) ? "is" : "is not")} a weekend night");

static bool IsWeekendNightShift(DateTime shiftDate) => shiftDate switch
{
    { Hour: >=15, DayOfWeek: DayOfWeek.Friday or DayOfWeek.Saturday} => true,
    _ => false 
};

static string PadAndTrim([AllowNull]string input, int length, char padChar)
{
    if (input == null)
    {
        return String.Empty.PadLeft(length, padChar);
    }
    else if (input != null && input.Length <= length)
    {
        switch(padChar)
        {
            case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') when padChar != 'x':
                return input.Trim().PadLeft(length, padChar);
            case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') when padChar == 'x':
                return string.Empty.PadLeft(length, '_');
            case >= '0' and <= '9':
                return input.Trim().PadRight(length, padChar);
            default:
                Console.WriteLine("No match found for pad character");
                break;
        }
        return input.Trim().PadLeft(length, padChar);
    }
    else
    {
        throw new ArgumentException("Input is longer than requested length");
    }
}

IPerson sw = new ShiftWorker { FirstName = "Shift", LastName = "Worker", StartDate = new DateOnly(2022, 7, 15) };
IPerson mgr = new Manager { FirstName = "Manager", LastName = "Worker", NumberOfDirectReports = 7 };

Console.WriteLine(GetPersonDetails(sw));
Console.WriteLine(GetPersonDetails(mgr));

static string GetPersonDetails(IPerson p)
{
    var result = p switch
    {
        ShiftWorker swv when swv.StartDate.Year > 2020 => $"{swv.FirstName} {swv.LastName}: {swv.StartDate}",
        ShiftWorker swv when swv.StartDate.Year <= 2020 => $"Older employee",
        Manager mgr => $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}",
        _ => string.Empty
    };

    return result;

    //ShiftWorker? swv = p as ShiftWorker;
    //if (p is ShiftWorker swv)
    //{
    //    return $"{swv.FirstName} {swv.LastName}: {swv.StartDate}";
    //}
    //else if (p is Manager mgr)
    //{
    //    return $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}";
    //}
    //return String.Empty;
}
