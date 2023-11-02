using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageWallRazorPages.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        [BindProperty]
        public string Message { get; set; } 

        public void OnGet()
        {
            //eventually this will read from the database
        }

        public IActionResult OnPost()
        {
            //instead of adding to this list - it eventually will post to database!
            Messages.Add(Message);

            return Page();
        }
    }
}
