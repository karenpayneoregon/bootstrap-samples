using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        string input = "\"'Hello, World!'\"";

        Console.WriteLine(input.RemoveStartAndEndQuotes());

        string lines = """
                       "Hello, World!"
                       "Hello, World!"
                       """;

        Console.WriteLine(lines.RemoveStartAndEndQuotes());

        Console.ReadLine();
    }

    //static string RemoveQuotes(this string input)
    //{
    //    string result = Regex.Replace(input, "^\"|\"$", "");
    //    return result;
    //}
}
public static partial class StringExtensions
{


  

    public static string RemoveQuotes(this string sender)
    {
        if (string.IsNullOrEmpty(sender))
        {
            return "";
        }

        var rgx = QuotesRegex();
        return rgx.Replace(sender, "").Trim();
    }
    public static string RemoveStartAndEndQuotes(this string sender)
        => ((sender?.Length ?? 0) < 2
            ? sender
            : sender!.Length > 1 && (sender[0] == '"' && sender[^1] == '"' ||
                                     sender[0] == '\'' && sender[^1] == '\'')
                ? sender.Substring(1, sender.Length - 2)
                : sender)!;

    [GeneratedRegex("^\"|\"$")]
    private static partial Regex QuotesRegex();
}



