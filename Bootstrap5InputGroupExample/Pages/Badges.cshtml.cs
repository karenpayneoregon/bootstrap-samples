using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5InputGroupExample.Pages;
public class PrivacyModel : PageModel
{

    [BindProperty]
    public int MailCount { get; set; } = 10;
    public void OnGet()
    {
    }
}

