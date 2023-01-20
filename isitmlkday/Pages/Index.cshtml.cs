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
            var today = DateTime.Now;
            var mlkDay = new DateTime(today.Year, 1, 18);
            if (today.Month == 1 && today.Day == 18)
            {
                IsMLKDay = "YES";
            }
            else
            {
                IsMLKDay = "NO";
            }
        }
    }
}
