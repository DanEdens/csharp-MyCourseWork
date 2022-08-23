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
//Console.WriteLine(PadAndTrim(input, 15, '0'));

//var shiftDay = GetShiftDays((DayOfWeek)17);
//Console.WriteLine(shiftDay);

static ShiftDays GetShiftDays(DayOfWeek day) => day switch
{
    DayOfWeek.Monday => ShiftDays.Monday,
    DayOfWeek.Tuesday => ShiftDays.Tuesday,
    DayOfWeek.Wednesday => ShiftDays.Wednesday,
    DayOfWeek.Thursday => ShiftDays.Thursday,
    DayOfWeek.Friday => ShiftDays.Friday,
    DayOfWeek.Saturday => ShiftDays.Saturday,
    DayOfWeek.Sunday => ShiftDays.Sunday,
    _ => throw new ArgumentException("Invalid day of week suppliied")

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
            case ' ':
            case '|':
                return input.Trim().PadLeft(length, padChar);
            case '0':
            case '9':
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

IPerson sw = new ShiftWorker { FirstName = "Shift", LastName = "Worker", StartDate = new DateOnly(2020, 7, 15) };
IPerson mgr = new Manager { FirstName = "Manager", LastName = "Worker", NumberOfDirectReports = 7 };

Console.WriteLine(GetPersonDetails(sw));
Console.WriteLine(GetPersonDetails(mgr));

static string GetPersonDetails(IPerson p)
{
    var result = p switch
    {
        ShiftWorker swv => $"{swv.FirstName} {swv.LastName}: {swv.StartDate}",
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
