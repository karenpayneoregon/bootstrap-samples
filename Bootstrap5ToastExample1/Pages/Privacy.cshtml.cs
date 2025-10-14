using Bootstrap5ToastExample1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5ToastExample1.Pages;
public class PrivacyModel : PageModel
{
    public ToastViewModel Toast { get; private set; } = new();

    public void OnGet()
    {
        Toast.Title = "Alert";
        Toast.Message = "Your privacy is important to us.";
        Toast.AutoHide = true;
        Toast.DelayMs = 2000;
    }
}

