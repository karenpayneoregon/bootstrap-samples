using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Bootstrap5InputGroupExample.Pages
{
    public class ModalPageModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public bool Confirmation { get; set; }

        public void OnPost()
        {
            Log.Information("Response: {P1}", Confirmation);
        }
    }
}
