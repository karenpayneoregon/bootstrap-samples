using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;
using System.Reflection;
using System.Text;

namespace Bootstrap5ModalExample.Pages;

public class MultipleInputsModel : PageModel
{
    [BindProperty]
    public UserData UserData { get; set; } = new ();
    [BindProperty]
    public bool Process { get; set; }


    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (Process)
        {
            Log.Information(GetPropertyValues(UserData));
        }
        else
        {
           Log.Information("Cancelled"); 
        }
    }
    private static string GetPropertyValues(UserData userData)
    {
        Type type = userData.GetType();
        PropertyInfo[] props = type.GetProperties();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Environment.NewLine);
        foreach (var prop in props)
        {
            sb.AppendLine($"{prop.Name} Value '{prop.GetValue(userData)}'");
        }
        return sb.ToString();
    }

}

public class UserData
{
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string Line3 { get; set; }
    public string Line4 { get; set; }
    public string Line5 { get; set; }
    public string Line6 { get; set; }
    public string Line7 { get; set; }
    public string Line8 { get; set; }
    public string Line9 { get; set; }
}