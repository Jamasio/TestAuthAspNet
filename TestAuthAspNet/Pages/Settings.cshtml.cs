using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAuthAspNet.Pages;

[Authorize (Policy ="AdminOnly")]
public class Settings : PageModel
{

    public void OnGet()
    {
    }
}
