// See https://aka.ms/new-console-template for more information

string randomString = GenerateRandomString();
Console.WriteLine(randomString);

List<int> sums = FindSums(randomString);
sums.ForEach(i => Console.Write(i+", "));

List<int> FindSums(string input)
{
    List<int> sums = new();
    string[] betweens = input.Split("?");
    foreach (string s in betweens)
    {
        int sum = 0;
        foreach (char c in s)
        {
            if (Char.IsDigit(c))
            {
                sum += int.Parse(c.ToString());
            }
        }
        sums.Add(sum);
    }

    return sums;
}

string GenerateRandomString()
{
    string chars = "abcdefghijklmnopqrstuvwxyz";
    Random rand = new Random();
    string result = "";
    for (int i = 0; i < 20; i++)
    {
        int next = rand.Next(5);
        if (next == 0 || next == 1) // append character
        {
            int chosenChar = rand.Next(0, chars.Length);
            result += chars[chosenChar];
        } else if (next == 2 || next == 3) // append number
        {
            result += rand.Next(10);
        }
        else // append question mark
        {
            result += "?";
        }
    }

    return result;
}