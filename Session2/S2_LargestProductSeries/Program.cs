// See https://aka.ms/new-console-template for more information


// the @ allows me to have line breaks for readability

string input = @"
7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843
8586156078911294949545950173795833195285320880551112540698747158523863050715693290963295227443043557
6689664895044524452316173185640309871112172238311362229893423380308135336276614282806444486645238749
3035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776
6572733300105336788122023542180975125454059475224352584907711670556013604839586446706324415722155397
5369781797784617406495514929086256932197846862248283972241375657056057490261407972968652414535100474
8216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586
1786645835912456652947654568284891288314260769004224219022671055626321111109370544217506941658960408
0719840385096245544436298123098787992724428490918884580156166097919133875499200524063689912560717606
0588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
input = input.Replace("\r", "").Replace("\n", "");

LargestProductOfXNumbers(input, 4);

Console.WriteLine("\n\n");
bool wasFound = LookForProductMatchingNumber(input, 126);
Console.WriteLine("Find target product? " + wasFound);

bool found = FoundMatchingGroups(input);

bool LookForProductMatchingNumber(string input, int targetProduct)
{
    List<int> productSequence = new();
    foreach (char c in input)
    {
        productSequence.Add(int.Parse(c.ToString()));
        if (productSequence.Count > 4)
        {
            productSequence.RemoveAt(0);
        }
        else if(productSequence.Count() < 4)
        {
            continue;
        }

        int product = 1;
        foreach (int i in productSequence)
        {
            product *= i;
        }

        if (product == targetProduct)
        {
            Console.WriteLine(productSequence);

            return true;
        }
    }

    return false;
}

// some day I'll improve this to just remove the first char and append the last char.
// And divide with the first, and the multiply with the last. Probably increases speed a bit. Someday.
void LargestProductOfXNumbers(string input, int x)
{
    string numbersOfProduct = "";
    int largestProduct = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (i > input.Length - x)
        {
            break;
        }

        string substring = input.Substring(i, x); // not super efficient
        int tmpProduct = 1;
        foreach (char c in substring)
        {
            int number = int.Parse(c.ToString());
            tmpProduct *= number;
        }

        if (tmpProduct > largestProduct)
        {
            largestProduct = tmpProduct;
            numbersOfProduct = substring;
        }
    }

    Console.WriteLine("Numbers: " + numbersOfProduct);
    Console.WriteLine("Largest product: " + largestProduct);
}

bool FoundMatchingGroups(string input)
{
    // TODO later..
    throw new NotImplementedException();
}