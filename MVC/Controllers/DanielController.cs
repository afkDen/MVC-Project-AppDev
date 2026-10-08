using Microsoft.AspNetCore.Mvc;
using MVC.Models.Portfolio;

namespace MVC.Controllers;

[Route("daniel")]
public class DanielController : Controller
{
    [HttpGet("")]
    public IActionResult Index() => View(new DanielProfileViewModel(
        "Mark Daniel L. Liwanag",
        "Computer Science undergraduate",
        "I'm a Computer Science student at the Polytechnic University of the Philippines. I work on frontend and backend web projects and build Roblox games. I like figuring out how systems work, and I'm interested in a future career in cybersecurity.",
        new[] { "HTML", "CSS", "JavaScript", "PHP", "Java", "SQL", "React", "Next.js", "React Native", "Expo", "Supabase", "Git" },
        new[] { "Web development", "Roblox game development", "Cybersecurity (future career interest)" },
        "https://github.com/afkDen",
        "https://danielshub.tech/"));
}
