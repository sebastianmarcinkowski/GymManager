using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;

public class ErrorController : Controller
{
    [Route("/Error")]
    public IActionResult Index()
    {
        return View("Error");
    }
}
