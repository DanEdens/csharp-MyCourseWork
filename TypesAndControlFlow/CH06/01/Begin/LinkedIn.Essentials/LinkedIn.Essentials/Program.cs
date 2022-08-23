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

Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 15, '0'));


static string PadAndTrim([AllowNull]string input, int length, char padChar)
{
    if (input == null)
        return String.Empty.PadLeft(length, padChar);
    else 
        return input.Trim().PadLeft(length, padChar);
}

