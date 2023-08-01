using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

#pragma warning disable CS8618

namespace BootstrapInputGroupValidateExample.Pages;

public class IndexModel : PageModel
{

    public Person Person { get; set; }
    [BindProperty]
    public string FirstName { get; set; }
    [BindProperty]
    public string LastName { get; set; }

    public void OnGet()
    {
        Person = new Person();
    }

    public void OnPost(Person person)
    {
        Log.Information("First {P1} Last {P2}", person.FirstName, person.LastName);
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public override string ToString() => $"{FirstName} {LastName}";

}