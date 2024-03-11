using BootstrapTableExample.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BootstrapTableExample.Pages
{
    public class DemoModel : PageModel
    {

        public string Message { get; set; }
        public List<string> MessageList { get; set; }

        public void OnGet()
        {
            Message = "On Demo Page";
        }

        public JsonResult OnGetList() => new JsonResult(MockData.FusionLogs());
    }
}


