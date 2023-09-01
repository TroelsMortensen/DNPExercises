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
}