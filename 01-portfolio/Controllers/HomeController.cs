using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_portfolio.Models;
using _01_portfolio.Services;

namespace _01_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IProjectService projectService;
    public HomeController(IProjectService projectService)
    {
        this.projectService = projectService;
    }

    public IActionResult Index()
    {
        var projects = projectService.GetProjects().Take(3).ToList();

        var model = new HomeIndexViewModel()
        {
            Projects = projects
        };

        return View(model);
    }

    public IActionResult Projects()
    {
        var projects = projectService.GetProjects();
        return View(projects);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
