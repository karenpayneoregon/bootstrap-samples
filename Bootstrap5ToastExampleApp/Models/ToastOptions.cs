using Microsoft.AspNetCore.Mvc;

namespace Bootstrap5ToastExampleApp.Models;

public class ToastOptions
{
    public string? ToastMessage { get; set; }

    public string? ToastTitle { get; set; }

    public int ToastDelay { get; set; }
}
