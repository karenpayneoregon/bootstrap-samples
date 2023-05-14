using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5ProgressBarExample.Pages
{
    public class RealPageModel : PageModel
    {
        [BindProperty]
        public int Current { get; set; }
        
        public void OnGet(int? current)
        {
            
            if (current.HasValue)
            {
                Current = current.Value;
                ViewData["Percentage"] = Current;
            }
            else
            {
                Current = 0;
                ViewData["Percentage"] = Current;
            }
        }

        public IActionResult OnPostUpdateProgress()
        {
            Current += 10;
            if (Current > 100)
            {
                return RedirectToPage("/RealPage", new { current = 0 });
            }
            else
            {
                ViewData["Percentage"] = Current;
                return RedirectToPage("/RealPage", new { current = Current });
            }

        }
    }
}
