// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

var e = new { FirstName = "Matt", LastName = "Milner",
    Kids = new string[] { "son1", "son2" }
};
string kid1 = e.Kids[1];
Console.WriteLine(e.FirstName);