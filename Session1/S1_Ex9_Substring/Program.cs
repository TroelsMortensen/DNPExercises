// See https://aka.ms/new-console-template for more information


MakeSubString("Hello", 2);
MakeSubString("Chocolate", 3);
MakeSubString("Chocolate", 1);

void MakeSubString(string input, int i)
{
    string start = input.Substring(0, i);
    string end = input.Substring(input.Length - i, i);
    Console.WriteLine(start + end);
}