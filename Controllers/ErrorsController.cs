using Microsoft.AspNetCore.Mvc;

namespace SentryErrorHandlingExample.Controllers;

public class ErrorsController : Controller
{
    public IActionResult Index() => View();
}
