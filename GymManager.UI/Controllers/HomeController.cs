using GymManager.Application.Tickets.Commands.AddTicket;
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
        await MediatR.Send(new AddTicketCommand { Name = "Test Ticket" });

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
