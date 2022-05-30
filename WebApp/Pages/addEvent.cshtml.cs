using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class AddEventCshtml : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AddEventCshtml(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnPost()
    {
    }
}