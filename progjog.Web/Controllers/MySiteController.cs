using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using progjog.Web.Models;

namespace progjog.Web.Controllers;

[Authorize]
public class MySiteController : Controller
{
    private readonly ILogger<MySiteController> _logger;

    public MySiteController(ILogger<MySiteController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult CreateTrainingProgram()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}