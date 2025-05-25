using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;
using Spectre.Console;

namespace Bootstrap5ModalExample.Pages;

public class Dialog1Model : PageModel
{
    [BindProperty]
    public string Recipient { get; set; }

    [BindProperty]
    public string Message { get; set; }

    [BindProperty]
    public bool Accepted { get; set; }

    [BindProperty]
    public bool AcceptedTerms { get; set; }

    public void OnPost()
    {
        
        if (Accepted)
        {
            if (!string.IsNullOrWhiteSpace(Recipient) && !string.IsNullOrWhiteSpace(Message))
            {
                Log.Information("\nSend to {P1} Message: \n{P2}",
                    Recipient,
                    Message);
            }
            else
            {
                Log.Information("Incomplete");
            }
        }
        else
        {
            Log.Information("Cancelled");
        }

        AnsiConsole.MarkupLine($"[{Color.Cyan1}]Accepted terms:[/] [{Color.Pink1}]{AcceptedTerms}[/]");

    }
    public void OnGet()
    {
        Recipient = "John Doe";
        Message = 
            """
            Now is the winter of our discontent.
            Made glorious summer by this sun of York;
            """;
    }
}