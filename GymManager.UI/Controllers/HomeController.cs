﻿using GymManager.Application.Tickets.Commands.AddTicket;
using GymManager.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GymManager.UI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //var ticket = await MediatR.Send(new GetTicketByIdQuery { Id = 1 });
            await MediatR.Send(new AddTicketCommand { Name = "New Ticket" });

            _logger.LogInformation("Index page says hello");
            _logger.LogWarning("Index page says hello");
            _logger.LogError("Index page says hello");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
