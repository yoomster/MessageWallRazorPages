using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WPFMessageWallLibrary;

namespace MessageWallRazorPages.Pages
{
    public class AddressPageModel : PageModel
    {

        [BindProperty]
        public AddressModel Address { get; set; }

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
            return RedirectToPage("./Index");
        }
    }
}
