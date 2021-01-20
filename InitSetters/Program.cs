using System;
using InitSetters;

var person = new Person
{
    Id = 1,
    FirstName = "Jarne",
    LastName = "Van Aerde"
};

Console.WriteLine($"Hello {person.FirstName} {person.LastName} ({person.Id})");