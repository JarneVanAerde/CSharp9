using System;
using Records;

Record1 r1a = new("Jarne", "Van Aerde");
Record1 r1b = new("Jarne", "Van Aerde");
Record1 r1c = new("Joske", "Vermeiren");

Class1 c1a = new("Jarne", "Van Aerde");
Class1 c1b = new("Jarne", "Van Aerde");
Class1 c1c = new("Joske", "Vermeiren");

Console.WriteLine("Record Type:");
//Console.WriteLine($"To String: {r1a}");
//Console.WriteLine($"Are equal: {Equals(r1a, r1b)}");
//Console.WriteLine($"Are equal by reference: {ReferenceEquals(r1a, r1b)}");
//Console.WriteLine($"Are equal ==: {r1a == r1b}");
//Console.WriteLine($"Are not equal !=: {r1a != r1c}");
//Console.WriteLine($"Hash code of object A: { r1a.GetHashCode()}");
//Console.WriteLine($"Hash code of object B: { r1b.GetHashCode()}");
//Console.WriteLine($"Hash code of object C: { r1c.GetHashCode()}");

Console.WriteLine();
Console.WriteLine("*********************************");
Console.WriteLine();

Console.WriteLine("Class Type:");
//Console.WriteLine($"To String: {c1a}");
//Console.WriteLine($"Are equal: {Equals(c1a, c1b)}");
//Console.WriteLine($"Are equal by reference: {ReferenceEquals(c1a, c1b)}");
//Console.WriteLine($"Are equal ==: {c1a == c1b}");
//Console.WriteLine($"Are not equal !=: {c1a != c1c}");
//Console.WriteLine($"Hash code of object A: { c1a.GetHashCode()}");
//Console.WriteLine($"Hash code of object B: { c1b.GetHashCode()}");
//Console.WriteLine($"Hash code of object C: { c1c.GetHashCode()}");




























//var (fn, ln) = r1a;
//Console.WriteLine($"The value of fn is {fn} and the value of ln is {ln}");

//Record1 r1d = r1a with
//{
//    FirstName = "Jan"
//};
//Console.WriteLine($"Jan's record: { r1d }");



































//Record2 r2a = new("Tim", "Verstreaten");
//Console.WriteLine($"R2a To String: {r2a}");
//Console.WriteLine($"R2a name: {r2a.FirstName} {r2a.LastName}");
//Console.WriteLine(r2a.SayHello());


































/// <summary>
/// Benefits:
/// - Simple to set up
/// - Thread-safe
/// - Easy/Safe to share
/// 
/// When to use records:
/// - Capturing external data that doesn't change
/// - API calls
/// - Processing data
/// </summary>