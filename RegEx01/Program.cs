using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        
        string text = Console.ReadLine();

        string pattern = @"\b[A-Z][a-z]{1,}[ ]{1}[A-Z][a-z]{1,}\b";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        List<string> result = new List<string>();

        foreach (Match match in matches)
        {
            result.Add(match.Value);
            
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
