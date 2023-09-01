// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
PrintEventNumbers(10);
Console.WriteLine("--------------------");
PrintEventNumbers(30);

void PrintEventNumbers(int x)
{
    for (int i = 0; i < x; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(x);
        }
    }    
}