using Bootstrap5ToastExampleApp.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5ToastExampleApp.Pages;
/// <summary>
/// This class is responsible for handling the logic related to displaying Bootstrap 5 toasts
/// on the Index page. It uses dependency injection to retrieve toast options and manages
/// TempData properties for toast message, title, and delay.
/// </summary>
public class IndexModel(ReadToast readToast) : PageModel
{
    [TempData]
    public string? ToastMessage { get; set; }

    [TempData]
    public string? ToastTitle { get; set; }

    [TempData]
    public int ToastDelay { get; set; }

    public void OnGet()
    {
    }

    /// <summary>
    /// Handles the POST request to display a Bootstrap 5 toast notification.
    /// </summary>
    /// <remarks>
    /// This method retrieves toast options such as title, message, and delay from the 
    /// <see cref="ReadToast"/> service and assigns them to the corresponding TempData properties.
    /// It then redirects the user back to the current page to display the toast.
    /// </remarks>
    /// <returns>
    /// An <see cref="IActionResult"/> that redirects to the current page.
    /// </returns>
    public IActionResult OnPostShowToast()
    {
        ToastTitle = readToast.GetToastOptions().ToastTitle;
        ToastMessage = readToast.GetToastOptions().ToastMessage;
        ToastDelay = readToast.GetToastOptions().ToastDelay;

        return RedirectToPage();
        
    }
}