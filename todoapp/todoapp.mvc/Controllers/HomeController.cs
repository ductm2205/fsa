using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using todoapp.mvc.Data;
using todoapp.mvc.Models;

namespace todoapp.mvc.Controllers;

public class HomeController(ILogger<HomeController> logger, TodoDbContext options) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly TodoDbContext _options = options;

    public IActionResult Index()
    {
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
