using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SuperSite.Models;

namespace SuperSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ItemsRepository _repository;

    public HomeController(ILogger<HomeController> logger, ItemsRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public IActionResult Index()
    {
        var items = _repository.Get();
        return View(items);
    }

    [HttpGet("api/items")]
    public ActionResult<IEnumerable<Item>> Get()
    {
        return Ok(_repository.Get());
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

