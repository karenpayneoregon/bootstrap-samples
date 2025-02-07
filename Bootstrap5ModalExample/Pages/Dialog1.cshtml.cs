using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Bootstrap5ModalExample.Pages;

public class Dialog1Model : PageModel
{
    [BindProperty]
    public string Recipient { get; set; }

    [BindProperty]
    public string Message { get; set; }

    [BindProperty]
    public bool Accepted { get; set; }

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