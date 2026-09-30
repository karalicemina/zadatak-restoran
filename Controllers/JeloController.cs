using Microsoft.AspNetCore.Mvc;
using zadatak.Data;
using zadatak.Models;
 
namespace zadatak.Controllers;

public class JeloController: Controller
{
    private readonly BazaContext _context;

    public JeloController(BazaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var jela = _context.Jela.ToList();
        return View(jela);
    }

    public IActionResult Create()
    {
        ViewBag.Restorani = _context.Restorani.ToList();
        return View();
    }

    [HttpPost] public IActionResult Create(Jelo jelo)
    {
        if (ModelState.IsValid)
        {
        _context.Jela.Add(jelo);
        _context.SaveChanges();
        return RedirectToAction("Index");
        }
        ViewBag.Restorani = _context.Restorani.ToList();
        return View(jelo);
    }
}