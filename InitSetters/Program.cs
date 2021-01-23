using System;
using InitSetters;

var person = new Person
{
    Id = 1,
    FirstName = "Joske",
    LastName = "Vermeiren"
};

Console.WriteLine($"Hello {person.FirstName} {person.LastName} ({person.Id})");