using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InfraStore.Models;

namespace InfraStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(string email,string password,string role)
    {
        if(email =="patilpritam1974@gmail.com" && password=="1974" && role=="vendor")
        {            
            return RedirectToAction("insert","items");
        }
        
        else if(email =="sghumare@gmail.com" && password=="2222" && role=="user")
        {
            return RedirectToAction("viewproduct","items");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(string firstname, string lastname, string email, string password, string contactnumber)
    {
        Boolean status=true;
        if(status)
        {
            return RedirectToAction("Login","Account");
        }
        return View();
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
