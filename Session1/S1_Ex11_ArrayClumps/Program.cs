// See https://aka.ms/new-console-template for more information

CountClumps(new[] { 1, 2, 2, 3, 4, 4 });
CountClumps(new[] { 1, 1, 2, 1, 1 });
CountClumps(new[] { 1, 1, 1, 1, 1 });
CountClumps(new[] { 2, 1, 2, 1, 2 });


void CountClumps(int[] numbers)
{
    bool insideClump = false;
    int previous = numbers[0];
    int clumpCount = 0;

    for (int i = 1; i < numbers.Length; i++)
    {
        int num = numbers[i];
        if (num == previous) // two numbers in a row are equal => we are in a clump
        {
            insideClump = true;
        }

        if (num != previous && insideClump) // detect that a clump ends
        {
            clumpCount++;
            insideClump = false;
        }

        previous = num;
    }

    // if the last clump contains the last number, it is not detected to end in the for-loop.
    // We count it here.
    if (insideClump)
    {
        clumpCount++;
    }

    Console.WriteLine(clumpCount);
}