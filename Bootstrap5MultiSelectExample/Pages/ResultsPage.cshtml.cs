using Bootstrap5MultiSelectExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Serilog;

namespace Bootstrap5MultiSelectExample.Pages
{
    public class ResultsPageModel : PageModel
    {
        [BindProperty]
        public List<Condiment> Condiments { get; set; }

        public ResultsPageModel()
        {
            Condiments = new List<Condiment>();
        }
        public void OnGet(string condiments)
        {
            if (string.IsNullOrWhiteSpace(condiments)) return;
            Condiments = JsonSerializer.Deserialize<List<Condiment>>(condiments)!;
            Log.Information(condiments);
        }
    }
}
