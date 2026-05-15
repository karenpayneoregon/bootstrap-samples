using Bootstrap5ToastExampleApp.Models;
using Microsoft.Extensions.Options;

namespace Bootstrap5ToastExampleApp.Classes;

public class ReadToast(IOptions<ToastOptions> options)
{
    private readonly ToastOptions _toastOptions = options.Value;

    public ToastOptions GetToastOptions()
    {
        return _toastOptions;
    }
}