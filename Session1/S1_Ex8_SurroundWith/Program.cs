// See https://aka.ms/new-console-template for more information

MakeOuterWord("<<>>", "Yay");
MakeOuterWord("<<>>", "WooHoo");
MakeOuterWord("[[]]", "word");

void MakeOuterWord(string outer, string inner)
{
    string outerStart = outer.Substring(0, 2);
    string outerEnd = outer.Substring(2, 2);
    string result = outerStart + inner + outerEnd;
    Console.WriteLine(result);
}