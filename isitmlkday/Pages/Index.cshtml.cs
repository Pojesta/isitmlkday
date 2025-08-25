using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace isitmlkday.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string IsMLKDay { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var today = DateTime.Today;
            var firstDay = new DateTime(today.Year, 1, 1);
            var mlkDay = firstDay.AddDays(((int)DayOfWeek.Monday - (int)firstDay.DayOfWeek + 7) % 7 + 14);
            IsMLKDay = today == mlkDay ? "YES" : "NO";
        }
    }
}
