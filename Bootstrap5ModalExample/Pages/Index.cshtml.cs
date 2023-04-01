using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Bootstrap5ModalExample.Pages;
public class IndexModel : PageModel
{
    [BindProperty]
    public bool Confirmation { get; set; }

    public void OnPost()
    {
        Log.Information("Response: {P1}", Confirmation);
    }
}
