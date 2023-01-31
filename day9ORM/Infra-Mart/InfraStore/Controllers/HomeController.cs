using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InfraStore.Models;

namespace InfraStore.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult AboutUs()
    {
        return View();
    }
    [HttpGet]
    public IActionResult ContactUs()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Services()
    {
       List<string> InfraServices=new List<string>();
        InfraServices.Add("Sell Your Product and grow your Buisseness");
        InfraServices.Add("Buy,Compare Products and there prices");
        InfraServices.Add("Add products to cart");
        return Json(InfraServices);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
