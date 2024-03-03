using GymManager.Application.Contacts.Commands.SendContactEmail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View(new SendContactEmailCommand());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Contact(
        SendContactEmailCommand command)
    {
        await MediatR.Send(command);

        return RedirectToAction("Contact");
    }
}
