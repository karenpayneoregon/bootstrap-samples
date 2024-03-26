using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace LoginFormsApp.Pages;
public class IndexModel : PageModel
{
    public void OnGet()
    {
        Log.Information("Greetings");
    }
}
