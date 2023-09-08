// See https://aka.ms/new-console-template for more information

IsPalindrome("mr owl ate my metal worm");
IsPalindrome("do geese see god");
IsPalindrome("was it a car or a cat i saw");
IsPalindrome("murder for a jar of red rum");
IsPalindrome("123454321");

bool IsPalindrome(string input)
{
    input = input.Replace(" ", ""); // remove white space
    IEnumerable<char> enumerable = input.Reverse();
    string reverse = new string(enumerable.ToArray());

    bool isPalindrome = reverse.Equals(input);
    Console.WriteLine("Is '"+input+"' a palindrome? " + isPalindrome);
    return isPalindrome;
}