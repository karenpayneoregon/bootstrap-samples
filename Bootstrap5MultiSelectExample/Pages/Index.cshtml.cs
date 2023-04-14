using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5MultiSelectExample.Pages;
public class IndexModel : PageModel
{
    [BindProperty]
    public string PizzaToppings { get; set; }

    public int[] ToppingsSelected { get; set; }

    public void OnGet()
    {
        PizzaToppings = "";
    }

    public RedirectResult OnPost()
    {

        if (!string.IsNullOrWhiteSpace(PizzaToppings))
        {
            ToppingsSelected = Array.ConvertAll(PizzaToppings.Split(','), int.Parse);
            return Redirect("Privacy");
        }
        else
        {
            return Redirect("Index");
        }
    }
}
