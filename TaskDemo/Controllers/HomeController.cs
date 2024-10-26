using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskDemo.Data;
using TaskDemo.Models;

namespace TaskDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDBContext _context;
    public HomeController(ILogger<HomeController> logger, AppDBContext appDBContext)
    {
        _logger = logger;
        _context = appDBContext;
    }

    public IActionResult Index()
    {
        return View();
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
    public IActionResult Login()
    {
        return PartialView();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(Login login)
    {
        if (ModelState.IsValid)
        {
            var user = await _context.users.Where(x => x.Name == login.Name && x.Password == login.Password).FirstOrDefaultAsync();
            if (user != null)
            {
                return RedirectToAction("Index", "Task");
            }
            else
            {
                ModelState.AddModelError("Name", "User not exist");
            }

        }
        return View("Index");
    }

}
