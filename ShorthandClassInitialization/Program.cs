using System;
using ShorthandClassInitialization;

Person p1 = new Person { Id = 1, FirstName = "Joske", LastName = "Vermeiren" };
Person p2 = new Person(2, "Anne", "Huisewijk");

Console.WriteLine($"Hello {p1.FirstName} {p1.LastName} ({p1.Id})");
Console.WriteLine($"Hello {p2.FirstName} {p2.LastName} ({p2.Id})");