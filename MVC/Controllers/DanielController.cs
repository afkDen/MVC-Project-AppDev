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

    [HttpGet("portfolio")]
    public IActionResult Portfolio() => View(new DanielPortfolioViewModel(
        "Mark Daniel L. Liwanag",
        new PortfolioProjectViewModel[]
        {
            new("Aya", "Web app / Hackathon",
                "An app that helps groups plan where to eat or go. It includes nearby places, itineraries, and AI-assisted decisions.",
                "Main Backend Developer / Co-Lead Developer",
                new[] { "Next.js", "TypeScript", "Supabase" },
                "https://github.com/afkDen/iNet_GitHub", "https://i-net-git-hub.vercel.app"),
            new("LakadPapel", "Offline-first mobile app",
                "A mobile app that works offline and maps out the documents needed for a government application. It uses a dependency graph to connect documents you have to the ones you need.",
                "Main Developer", new[] { "React Native", "Expo", "TypeScript" },
                "https://github.com/afkDen/lakad_papel"),
            new("SubSqueeze", "Shared expense & subscription ledger",
                "An app for households and student groups to track shared expenses, subscriptions, and payments between members.",
                "Main Developer", new[] { "Next.js", "TypeScript", "Supabase" },
                "https://github.com/afkDen/subsqueeze", "https://subsqueeze.vercel.app")
        }));
}