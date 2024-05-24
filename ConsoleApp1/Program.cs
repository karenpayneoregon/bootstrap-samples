    using System.Text.RegularExpressions;

    namespace ConsoleApp1;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "\"Hello, World!\"";
            string result = RemoveQuotes(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string RemoveQuotes(string input)
        {
            string result = Regex.Replace(input, "^\"|\"$", "");
            return result;
        }
    }



