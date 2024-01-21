using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            // Verify Credential
            if (Credential != null && Credential.UserName == "admin" && Credential.Password == "password")
            {
                // Creating Security Context
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@localhost"),
                    new Claim("Department", "HR"),
                    new Claim("Admin", "true"),
                    new Claim("Manager", "true"),
                    new Claim("EmploymentDate", "21-08-2023")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");

                // Add the Security Context to the ClaimPrincipal
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                // Make cookie persistent
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = Credential.RememberMe
                };
                // Serialize the ClaimsPrincipal into a string then encrypt it. Save it in a cookie in the HttpContext.
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal, authProperties);

                return RedirectToPage("/Index");
            }
            
            return Page();
        }
    }