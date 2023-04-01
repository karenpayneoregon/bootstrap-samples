using Bootstrap5InputGroupExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Bootstrap5InputGroupExample.Pages;
public class IndexModel : PageModel
{

    [BindProperty]
    public Person Person { get; set; } = default!;

    public string BadgeText { get; set; } = "Code samples";

    public void OnPost()
    {
        Log.Information("{P1} {P2} mail: {P3} user name: {P4} Agree: {P5} Sig: {P6}", 
            Person.FirstName,
            Person.LastName, 
            Person.EmailAddress, 
            Person.UserName, 
            Person.AgreeToTerms, 
            Person.Signature);
    }
}
