using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using progjog.Web.Data.Repositories;
using progjog.Web.Models;

namespace progjog.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITrainingPlanRepository _trainingPlanRepository;

    public HomeController(ILogger<HomeController> logger, ITrainingPlanRepository trainingPlanRepository)
    {
        _logger = logger;
        _trainingPlanRepository = trainingPlanRepository;
    }

    public IActionResult Index()
    {
        var trainingPlanViewModels = _trainingPlanRepository.GetAll();
        return View(trainingPlanViewModels);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}