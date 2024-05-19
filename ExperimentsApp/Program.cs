namespace ExperimentsApp;

internal partial class Program
{
    public static int identifier { get; set; }
    static void Main(string[] args)
    {
        identifier = 0;
        int OnError(string message = "")
        {
            // log error
            return -1;
        }

        try
        {
            var lines = File.ReadAllLines("stuff.txt");
        }
        catch (Exception ex)
        {
            identifier = ex switch
            {
                _ when ex is UnauthorizedAccessException or FileNotFoundException => OnError(),
                _ => OnError("Unknown")
            };
        }


        AnsiConsole.MarkupLine($"[yellow]{identifier}[/]");
        Console.ReadLine();
    }

}