// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Classes();
Structs();
Records();


static void Classes()
{
    Console.WriteLine("=========== Classes = reference types ===========");
    //Create an employee
    Employee me = new Employee
    {
        FirstName = "Matt",
        LastName = "Milner",
        Age = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 },
        Id = 1
    };

    //create another reference to the employee
    IPerson other = me;
    other.FirstName = "Bizarro Matt";
    other.Age = new Age { BirthDate = new DateTime(1980, 9, 1), YearsOld = 39 };

    //examine results of the original object
    Console.WriteLine($"{me.FirstName} is {me.Age.YearsOld} but {other.FirstName} is {other.Age.YearsOld}");
    Console.WriteLine();

    //ChangeName(ref other);
    ChangeName(other);
    Console.WriteLine($"{other.FirstName} {other.LastName} is still {other.Age.YearsOld}");

    Console.WriteLine();
}

//static void ChangeName(ref IPerson person)
static void ChangeName( IPerson person)
{
    person.LastName = "Unknown";
    Console.WriteLine($"Person in method is {person.FirstName} {person.LastName}");

    person = new Manager("Manager", "Milner")
    {
        Id = 2,
        Age =
        new Age { BirthDate = new DateTime(1990, 1, 1), YearsOld = 31 }
    };

    Console.WriteLine($"Person after reference change in method is {person.FirstName}");
}
static void Structs()
{
    Console.WriteLine("=========== Structs = value types ===========");

    Age myAge = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 };
    Age anotherAge = myAge;

    anotherAge.YearsOld = 39;

    Console.WriteLine($"My age is {myAge.YearsOld}, but I changed it to {anotherAge.YearsOld}");

    AgeBackwords(ref anotherAge, 5);

    Console.WriteLine($"Now I am {anotherAge.YearsOld}");
    Console.WriteLine();
}

static void Records()
{
    Console.WriteLine("=========== Records = reference or value types ===========");

    PremiereCustomer pc = new PremiereCustomer
    {
        FirstName = "Customer",
        LastName = "One",
        Id = 7,
        Age = new Age { BirthDate = DateTime.Now, YearsOld = 1 },
        CustomerLevel = 1
    };

    PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Two" };

    Console.WriteLine($"{pc.FirstName} {pc.LastName} has a level of {pc.CustomerLevel}");
    Console.WriteLine($"{pc2.FirstName} {pc2.LastName} has a level of {pc2.CustomerLevel}");
    ChangeName((IPerson)pc);
    Console.WriteLine($"{pc.FirstName} {pc.LastName} is still {pc.Age.YearsOld}");

}

static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
{
    startingAge.YearsOld = startingAge.YearsOld - numberOfYearsToAge;
    Console.WriteLine($"Modified age in method: {startingAge.YearsOld}");
}




