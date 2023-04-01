#nullable enable
using Bootstrap5ToastExample.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
#pragma warning disable CS8618
#pragma warning disable CS8602
#pragma warning disable CS8604


namespace Bootstrap5ToastExample.Pages;
public class PrivacyModel : PageModel
{
    [BindProperty]
    public string TopMessage { get; set; }
    [BindProperty]
    public string BottomMessage { get; set; }
    public void OnGet(string containers)
    {
        if (!string.IsNullOrWhiteSpace(containers))
        {
            List<ToastContainer>? data = JsonSerializer.Deserialize<List<ToastContainer>>(containers);
            TopMessage = data.FirstOrDefault(x => x.Name == "Top").Body;
            BottomMessage = data.FirstOrDefault(x => x.Name == "Bottom").Body;
        }
        else
        {
            TopMessage = "Top message";
            BottomMessage = "Bottom message";
        }
    }


}

