using System;
using System.Collections.Generic;
using ShorthandClassInitialization;

Person p1 = new Person { Id = 1, FirstName = "Joske", LastName = "Vermeiren" };
Person p2 = new Person(2, "Anne", "Huisewijk");
Person p3 = null;

List<Person> personList = new List<Person>()
{
    p1, p2, p3
};

foreach (var person in personList)
{
    if (person is null)
    {
        Console.WriteLine("This person does not exist...");
    }
    else
    {
        Console.WriteLine($"Hello {person.FirstName} {person.LastName} ({person.Id})");
    }
}