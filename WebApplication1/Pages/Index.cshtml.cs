using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Text;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string P_Case => (string)TempData[nameof(P_Case)];
        TextInfo textInfo = new CultureInfo("en-US",false).TextInfo;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost([FromForm] string pcase)
        {
            TempData["Name"] = textInfo.ToTitleCase(pcase);
            //TempData["Name"] = name;
            return RedirectToPage("Index");

                
        }
    }
}