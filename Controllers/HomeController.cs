using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using zadatak.Models;
using zadatak.Data;
using Microsoft.EntityFrameworkCore;

namespace zadatak.Controllers;

public class HomeController : Controller
{

    private readonly BazaContext _context;

    public HomeController(BazaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Predlozi()
    {
        var jela = _context.Jela.Include(j => j.Restoran).ToList();
        if (jela.Count == 0)
        { 
            return View();
        }
        Random random = new Random();
        int broj = random.Next(jela.Count);
        var jelo = jela[broj];
        return View(jelo);
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
