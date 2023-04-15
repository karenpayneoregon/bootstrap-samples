using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;
using System.Text.Json;
using Bootstrap5MultiSelectExample.Classes;
using Bootstrap5MultiSelectExample.Models;

#pragma warning disable CS8618

namespace Bootstrap5MultiSelectExample.Pages;
public class IndexModel : PageModel
{
    [BindProperty]
    public string PizzaToppings { get; set; }

    [BindProperty]
    public bool AllCondimentSelected { get; set; }

    [BindProperty]
    public int[] ToppingsSelected { get; set; }

    public void OnGet()
    {

    }

    /// <summary>
    /// First check to see if all options were selected, if not than
    /// get user selected toppings
    ///
    /// Pass selected to result page
    ///
    /// If no selections stay on index page
    /// </summary>
    /// <returns></returns>
    public IActionResult OnPost()
    {
        if (AllCondimentSelected)
        {
            var data = MockedData.Condiments();

            foreach (var value in data)
            {
                value.Selected = true;
            }
            return RedirectToPage("ResultsPage", new
            {
                condiments = JsonSerializer.Serialize(data, 
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    })
            });

        }
        else
        {
            if (!string.IsNullOrWhiteSpace(PizzaToppings))
            {
                ToppingsSelected = Array.ConvertAll(PizzaToppings.Split(','), int.Parse);
                
                var data = MockedData.Condiments();
                
                foreach (var value in ToppingsSelected)
                {
                    data.FirstOrDefault(x => x.Value == value)!.Selected = true;
                }

                return RedirectToPage("ResultsPage", new
                {
                    condiments = JsonSerializer.Serialize(
                        data.Where(x => x.Selected).ToList(), 
                        new JsonSerializerOptions
                        {
                            WriteIndented = true
                        })
                });
            }
            else
            {
                return Redirect("Index");
            }
        }

    }
}
