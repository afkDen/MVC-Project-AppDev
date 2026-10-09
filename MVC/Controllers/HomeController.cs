using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Privacy() => View();
    public IActionResult F3() => View("mitch");

    [HttpGet("team")]
    public IActionResult Team() => View(new TeamMemberViewModel[]
    {
        new("Mark Daniel L. Liwanag", "DL"),
        new("Yeshaya I. Evaristo", "YE"),
        new("Mitch N. Montales", "MM")
    });

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View();
}