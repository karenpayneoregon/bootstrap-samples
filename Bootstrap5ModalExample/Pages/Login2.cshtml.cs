using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5ModalExample.Pages
{
    
    public class Login2Model : PageModel
    {
        [BindProperty]
        public int Pin { get; set; }
        [BindProperty]
        public string UserName { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            var name = UserName;
            if (Pin == 1234)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
