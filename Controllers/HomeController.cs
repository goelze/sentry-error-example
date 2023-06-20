using Microsoft.AspNetCore.Mvc;

namespace SentryErrorHandlingExample.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Test()
    {
        throw new Exception("This is an example exception");
    }
}
