using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginFormsApp.Pages
{
    public class Login2Model : PageModel
    {
        [BindProperty]
        public string RuleHeader { get; set; } = "Password Rules";

        [BindProperty]
        public string Rules { get; set; } = "Password must be at least 8 characters long, contain at least one number, one uppercase letter, one lowercase letter, and one special character.";
        public void OnGet()
        {
        }
    }
}
