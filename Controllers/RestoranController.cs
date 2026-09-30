using Microsoft.AspNetCore.Mvc;
using zadatak.Data;
using zadatak.Models;

namespace zadatak.Controllers;

public class RestoranController: Controller
{
    private readonly BazaContext _context;

    public RestoranController(BazaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var restorani = _context.Restorani.ToList();
        return View(restorani);
    }

    public IActionResult Create()
    {
    return View();
    }

    [HttpPost] public IActionResult Create(Restoran restoran)
    {
        if (ModelState.IsValid)
        {
        _context.Restorani.Add(restoran);
        _context.SaveChanges();
        return RedirectToAction("Index");
        }
        return View(restoran);
    }
}