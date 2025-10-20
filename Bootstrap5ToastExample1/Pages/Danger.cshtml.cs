using Bootstrap5ToastExample1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5ToastExample1.Pages;

public class DangerModel : PageModel
{
    public ToastViewModel Toast { get; private set; } = new();

    public void OnGet()
    {
        Toast.Title = "Alert";
        Toast.Message = "Failed to update record!!!";
        Toast.AutoHide = false;
        Toast.DelayMs = 4000;
    }
}