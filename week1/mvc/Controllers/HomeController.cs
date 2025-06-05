using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using M4Flex_netmvc_main.Models;

namespace M4Flex_netmvc_main.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Index()
    {
        Newsitem item = new Newsitem
        {
            Title = "Welcome to M4Flex",
            Content = "This is a sample news item for the M4Flex application.",
            ImageUrl = "img/news1.jpg"
        };
        return View(item);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
