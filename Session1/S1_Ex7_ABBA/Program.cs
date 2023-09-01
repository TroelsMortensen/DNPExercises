// See https://aka.ms/new-console-template for more information


MakeAbba("Hi", "Bye");
MakeAbba("Yo", "Alice");
MakeAbba("What", "Up");

void MakeAbba(string a, string b)
{
    Console.WriteLine($"{a}{b}{b}{a}");
}