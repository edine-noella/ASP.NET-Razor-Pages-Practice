using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Razor_Pages_Practice.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public StudentFormModel StudentForm { get; set; }
    public void OnGet()
    {
        StudentForm = new StudentFormModel();
    }
}