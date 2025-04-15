using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Razor_Pages_Practice.Pages;

public class StudentFormModel : PageModel
{
    [BindProperty] // 👈 This tells ASP.NET to bind form data to this property
    public string Name { get; set; }

private readonly ILogger<StudentFormModel> _logger;

public StudentFormModel(ILogger<StudentFormModel> logger)
{
    _logger = logger;
}


    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        
    }
}