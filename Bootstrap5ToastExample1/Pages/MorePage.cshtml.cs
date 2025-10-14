using Bootstrap5ToastExample1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Bootstrap5ToastExample1.Pages;

public class MorePageModel : PageModel
{
    public ToastViewModel Toast { get; private set; } = new();

    public void OnGet()
    {
        Toast.Title = "Alert";
        Toast.Message = "From get";
        Toast.AutoHide = true;
        Toast.DelayMs = 2000;
    }

    public PageResult OnPostSubmit()
    {

        Toast.Title = "Hey";
        Toast.Message = "Message has changed";
        Toast.AutoHide = true;
        Toast.DelayMs = 2000;
        return Page();
    }
}