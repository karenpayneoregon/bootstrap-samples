using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Bootstrap5ColumnsExamples.Pages;
public class IndexModel : PageModel
{
    public void OnGet()
    {
        Log.Information("Greetings");
    }
}
