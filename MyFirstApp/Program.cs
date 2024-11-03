// See https://aka.ms/new-console-template for more information
using System.Net.Security

string firstName, lastName;

firstName = "Harry";
lastName = "Potter";

NewMethod(firstName, lastName);

static void NewMethod(string firstName, string lastName)
{
    Console.WriteLine($"Hello",firstName + lastName!);
}