namespace S1_Ex5_Calculator.MathLib;

public class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Add(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }


    // Exercise 6
    public static void LargestOfTwo()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int num1 = Int32.Parse(s1);
        int num2 = Int32.Parse(s2);

        if (num1 > num2)
        {
            Console.WriteLine("Largest: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("Largest: " + num2);
        }
        else
        {
            Console.WriteLine("Numbers are equal");
        }
    }
}