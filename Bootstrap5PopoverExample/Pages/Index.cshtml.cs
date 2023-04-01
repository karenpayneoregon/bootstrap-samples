using Bootstrap5PopoverExample.Classes;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5PopoverExample.Pages;
public class IndexModel : PageModel
{


    public List<PopOverContainer> PopContainer { get; set; }
    public IndexModel()
    {
        PopContainer = MockedData.PopOverList();
    }

    public void OnGet()
    {

    }
}