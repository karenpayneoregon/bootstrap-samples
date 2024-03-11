using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScrollspyInNavbarExample.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public List<Sentence> Sentences { get; set; }
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Sentences = BogusOperations.MainSentences();
    }

    public void OnGet()
    {

    }
}

public class Sentence
{
    public int Id { get; set; }
    public string Text { get; set; }
    public override string ToString() => Text;

}

public class BogusOperations
{
    public static List<Sentence> MainSentences()
    {
        var list = new List<Sentence>();
        var dataSet = new Bogus.DataSets.Lorem();
        for (int index = 0; index < 5; index++)
        {
            list.Add(new Sentence() { Id = index +1, Text = dataSet.Sentence(100) });
        }

        return list;
    }
}
