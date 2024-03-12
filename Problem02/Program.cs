using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
      
        string text = Console.ReadLine();

        string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

       

        foreach (Match match in matches)
        {
            Console.Write(match.Value + ", ");
        }
    }
}
