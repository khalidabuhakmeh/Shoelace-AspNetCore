using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SweetKicks.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    [TempData]
    public string? Name { get; set; }
    
    public void OnGet()
    {
    }

    public RedirectToPageResult OnPost([FromForm] string name)
    { 
        logger.LogInformation("Name is {Name}", name);
        Name = name;
        return RedirectToPage();
    }
}