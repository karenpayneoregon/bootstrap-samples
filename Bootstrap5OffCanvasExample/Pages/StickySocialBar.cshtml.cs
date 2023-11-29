using Bootstrap5OffCanvasExample.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap5OffCanvasExample.Pages
{
    
    public class StickySocialBarModel : PageModel
    {
        [BindProperty]
        public List<Sentence> MainSentences { get; set; }
        [BindProperty]
        public List<Sentence> NoticeSentences { get; set; }
        public void OnGet()
        {
            // mock-up data that would come from a database 
            MainSentences = BogusOperations.MainSentences();
            NoticeSentences = BogusOperations.NoticeSentences();
        }
    }
}