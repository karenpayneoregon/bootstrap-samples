using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Bootstrap5MultiSelectExample.Classes;
using Serilog;

#pragma warning disable CS8618

namespace Bootstrap5MultiSelectExample.Pages;

public class Dialog1Model : PageModel
{
    [BindProperty]
    public string PizzaToppings { get; set; }

    [BindProperty]
    public bool AllCondimentSelected { get; set; }

    [BindProperty]
    public int[] ToppingsSelected { get; set; }
    [BindProperty]
    public bool UserCancelled { get; set; }

    public IActionResult OnPostCloseButton(IFormCollection data)
    {
        Log.Information($"User cancelled selecting any toppings");
        return RedirectToPage("Index",new {message = "No toppings for me"});
    }
    public IActionResult OnPostConfirmButton(IFormCollection formCollection)
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

            return Redirect("Index"); // never reached
        }

    }
}