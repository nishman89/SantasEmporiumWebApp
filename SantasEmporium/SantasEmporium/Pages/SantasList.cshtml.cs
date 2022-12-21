using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SantasEmporium.Models;
using SantasEmporium.Services;

namespace SantasEmporium.Pages
{
    public class SantasListModel : PageModel
    {
        public List<Recipient> recipients = new();

        // Binding the powerty to the page
        [BindProperty]
        public Recipient NewRecipient { get; set; }
        public void OnGet()
        {
            recipients = RecipientService.GetAll();
        }

        public IActionResult OnPost()
        {
            RecipientService.Add(NewRecipient);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            RecipientService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
