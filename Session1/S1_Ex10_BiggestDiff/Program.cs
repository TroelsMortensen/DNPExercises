// See https://aka.ms/new-console-template for more information

FindDiff(new []{10, 3, 5, 6});
FindDiff(new []{7, 2, 10, 9});
FindDiff(new []{2, 10, 7, 2});

void FindDiff(int[] numbers)
{
    int smallest = numbers[0];
    int largest = numbers[0];
    foreach (int number in numbers)
    {
        if (number < smallest) smallest = number;
        if (number > largest) largest = number;
    }

    Console.WriteLine(largest-smallest);
}