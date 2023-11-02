using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageWallRazorPages.Pages
{
    public class PersonalInfoPageModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
