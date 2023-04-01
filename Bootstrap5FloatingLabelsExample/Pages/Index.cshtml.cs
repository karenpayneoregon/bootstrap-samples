using Bootstrap5FloatingLabelsExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Serilog;

#pragma warning disable CS8601

namespace Bootstrap5FloatingLabelsExample.Pages;
public class IndexModel : PageModel
{
    public IndexModel()
    {
        Introduction = new Introduction();
    }

    [BindProperty]
    public Introduction Introduction { get; set; }

    /// <summary>
    /// Provides option to turn off auto-complete for a form
    /// </summary>
    [BindProperty]
    public bool UseAutoComplete { get; set; }

    /// <summary>
    /// From post in form1
    /// </summary>
    /// <param name="introduction"></param>
    public void OnGet(string introduction)
    {
        UseAutoComplete = true;

        if (!string.IsNullOrWhiteSpace(introduction))
        {

            // json is only formatted for demonstration only
            Log.Information("introduction as json {P1}{P2}", 
                Environment.NewLine, 
                introduction);
        }
    }
    public IActionResult OnPost()
    {
        /*
         * Yep we could also bind properties
         */
        Introduction.Name = Request.Form["Name"];
        Introduction.Surname = Request.Form["Surname"];
        Introduction.IsActive = Request.Form["isActive"] == "on"; 

        Log.Information("Name {P1} Surname {P2} Active {P3}", 
            Introduction.Name, 
            Introduction.Surname,
            Introduction.IsActive);
       

        return RedirectToPage("Index", new
        {
            introduction = JsonSerializer.Serialize(Introduction, new JsonSerializerOptions
            {
                WriteIndented = true
            })
        });
    }
}
