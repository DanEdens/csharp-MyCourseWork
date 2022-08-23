// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

string input = null;
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 17;

if(input != null)
{
    Console.WriteLine("String is :{0}", input);
}

if(age != null)
{
    Console.WriteLine($"Age is: {age}");
}

if(age.HasValue)
{
    Console.WriteLine($"Age is: {age.Value}");
}