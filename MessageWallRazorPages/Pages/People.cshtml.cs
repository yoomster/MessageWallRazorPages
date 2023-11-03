using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WPFMessageWallLibrary;

namespace MessageWallRazorPages.Pages
{

    public class PeopleModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //should save to a DB eventually
            return RedirectToPage("./AddressPage");
        }
    }
}
