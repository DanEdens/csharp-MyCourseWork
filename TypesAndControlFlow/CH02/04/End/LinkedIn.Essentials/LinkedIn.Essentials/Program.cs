// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Employee e = new Employee("Matt", "Milner", 75)
{
    StartDate = new DateOnly(2021, 1, 15)
};

Console.WriteLine($"From {e.FirstName}  id {e.Id}, hello world");

//PremiereCustomer pcust = new PremiereCustomer (2);
PremiereCustomer pcust = new PremiereCustomer { CustomerLevel = 2};
pcust.FirstName = "New Customer";

Console.WriteLine($"{ pcust.FirstName} has level {pcust.CustomerLevel}");

Manager m = new Manager("manager", "boss");
m.SetReports(7);


