namespace Bootstrap5ToastExample1.Models;

/// <summary>
/// Represents the view model for a Bootstrap 5 toast notification.
/// </summary>
public class ToastViewModel
{
    public string Title { get; set; } = "Notice";
    public string Message { get; set; } = "Button clicked.";
    public bool AutoHide { get; set; } = true;
    public int DelayMs { get; set; } = 5000; // optional, if you use it
}