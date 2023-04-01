using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using Bootstrap5OffCanvasExample.Classes;
using Serilog;

#pragma warning disable CS8618

namespace Bootstrap5OffCanvasExample.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public List<string> Months { get; set; }
        [BindProperty]
        public List<string> Days { get; set; }
        [BindProperty]
        public string CurrentDay { get; set; }

        public List<string> Sentences { get; set; }


        /// <summary>
        /// Selected day from off-canvas using index starting with 1 so
        /// in post we subtract 1 as <see cref="DayOfWeek"/> is 0 based.
        /// </summary>
        [BindProperty]
        public int SelectedDayIndex { get; set; }
        public void OnGet()
        {
            Months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();
            Days = DateTimeFormatInfo.CurrentInfo.DayNames.ToList();
            CurrentDay = DateTime.Now.DayOfWeek.ToString();
            Sentences = MockedData.SentenceList();
        }

        public IActionResult OnPostButton1()
        {
            Log.Information("Selected day {P1}", Enum.GetName(typeof(DayOfWeek), SelectedDayIndex -1));
            return RedirectToPage("Index");
        }
    }
}
