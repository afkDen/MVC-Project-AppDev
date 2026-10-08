using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Privacy() => View();
}
