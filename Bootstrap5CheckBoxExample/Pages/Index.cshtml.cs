using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Bootstrap5CheckBoxExample.Pages;
public class IndexModel : PageModel
{
    [BindProperty]
    public bool SugarCheckbox { get; set; }

    [BindProperty]
    public bool CremeCheckbox { get; set; }

    public void OnPost()
    {
        Log.Information("Add sugar {P1}", SugarCheckbox);
        Log.Information("Add creme {P1}", CremeCheckbox);
    }
}
