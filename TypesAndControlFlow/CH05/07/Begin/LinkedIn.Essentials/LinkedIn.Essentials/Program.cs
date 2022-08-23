// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

string input = null;
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");


//if (age != null)
//{
//    Console.WriteLine($"Age is: {age}");
//}

//if(age.HasValue)
//{
//    Console.WriteLine($"Age is: {age.Value}");
//}