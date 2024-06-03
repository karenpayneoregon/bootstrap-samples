using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DarkLightMode.Pages
{
    public class AboutModel : PageModel
    {
        [BindProperty]
        public Models.Introduction Introduction { get; set; }
        /// <summary>
        /// Provides option to turn off auto-complete for a form
        /// </summary>
        [BindProperty]
        public bool UseAutoComplete { get; set; }
        public AboutModel()
        {
            Introduction = new Models.Introduction();
        }
        public void OnGet()
        {
            UseAutoComplete = true;
        }
    }
}
