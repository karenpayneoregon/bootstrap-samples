using Bootstrap5ToastExample1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Bootstrap5ToastExample1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IndexModel(ILogger<IndexModel> logger) => _logger = logger;

    public ToastViewModel Toast { get; private set; } = new();

    public void OnGet()
    {
        Toast.Title = "FYI";
        Toast.Message = "Operation completed";
        Toast.AutoHide = true;
        Toast.DelayMs = 6000;
    }
}