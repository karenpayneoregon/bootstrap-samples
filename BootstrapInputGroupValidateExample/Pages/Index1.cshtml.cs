using BootstrapInputGroupValidateExample.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BootstrapInputGroupValidateExample.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string SocialSecurityNumber { get; set; } = "555-91-2345".MaskSsn(5,'*');
        public void OnGet()
        {
        }
    }
}
