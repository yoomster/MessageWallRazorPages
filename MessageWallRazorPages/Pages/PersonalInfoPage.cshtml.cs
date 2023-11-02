using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageWallRazorPages.Pages
{
    public class PersonalInfoPageModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }

        public string WelcomeByNames => $"Hi {FirstName} {LastName}";

        public void addNamesButton_Click()
        {
            Console.WriteLine($"Hi {FirstName} {LastName}");
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
