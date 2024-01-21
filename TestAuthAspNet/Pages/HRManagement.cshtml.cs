using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace TestAuthAspNet.Pages;

[Authorize (Policy =("HRManagement"))]
public class HRManagement : PageModel
{
    public void OnGet()
    {
    }
}
