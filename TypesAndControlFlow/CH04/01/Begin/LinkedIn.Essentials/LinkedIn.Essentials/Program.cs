// See https://aka.ms/new-console-template for more information
using LE= LinkedIn.Essentials;
using LET = LinkedIn.Essentials.Types;
//using System;
using Newtonsoft.Json;

LE.Employee e = new LE.Manager();
e.FirstName = "Hello";
JsonSerializer s = new JsonSerializer();
s.Serialize(Console.Out, e);

//e.IsActive();

Console.WriteLine(e.FirstName);