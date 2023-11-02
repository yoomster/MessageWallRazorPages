using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageWallRazorPages.Pages
{
    public class AddressPageModel : PageModel
    {

        [BindProperty]
        public string StreetName { get; set; }
        [BindProperty]
        public string HouseNr { get; set; }
        [BindProperty]
        public string PostCode { get; set; }
        [BindProperty]
        public string City { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
