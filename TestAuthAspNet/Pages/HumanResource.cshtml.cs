using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAuthAspNet.Pages;

[Authorize(Policy ="MustBelongToHRDepartment")]
public class HumanResource : PageModel

{
    public void OnGet()
    {
    }
}