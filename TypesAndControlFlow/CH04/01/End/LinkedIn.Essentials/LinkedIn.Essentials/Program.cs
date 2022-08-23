// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;


IPerson e = new ShiftWorker();
e.FirstName = "Hello";
((ShiftWorker)e).ShiftStartTime = new TimeOnly(8, 30);


Console.WriteLine(e.FirstName);