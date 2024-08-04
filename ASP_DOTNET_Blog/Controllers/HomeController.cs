using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP_DOTNET_Blog.Models;

namespace ASP_DOTNET_Blog.Controllers;

public class HelloWorldController: Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action";
    }

    // 
    // GET: /HelloWorld/Welcome/
    public string Welcome()
    {
        return "This is the Welcome action method....";
    }
}

// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;

//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }

//     public IActionResult Index()
//     {
//         return View();
//     }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }
