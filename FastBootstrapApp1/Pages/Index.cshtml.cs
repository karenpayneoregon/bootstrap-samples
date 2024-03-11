using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace FastBootstrapApp1.Pages;
public class IndexModel : PageModel
{
    public void OnGet()
    {
        Log.Information("Greetings");
    }
}
