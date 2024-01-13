using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAuthAspNet.Models.Credential;

namespace TestAuthAspNet.Pages.Account;
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential? Credential { get; set; } = new Credential();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            
        }
    }