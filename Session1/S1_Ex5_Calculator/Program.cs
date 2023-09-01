// See https://aka.ms/new-console-template for more information

using S1_Ex5_Calculator.MathLib;

Console.WriteLine("Hello, World!");

int result = Calculator.Add(3, 7);
Console.WriteLine("3 + 7 = " +result);

int[] numbers = new []{3,5,8,9};
int result1 = Calculator.Add(numbers);
Console.WriteLine(result1);


// Exercise 6
Calculator.LargestOfTwo();