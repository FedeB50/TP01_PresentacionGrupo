using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        grupo.cargaDatosManual();
        ViewBag.Grupo = grupo;
        return View();
    }
    public IActionResult SelectIntegrante(int dni)
    {
        Grupo grupo = new Grupo();
        grupo.cargaDatosManual();
        Integrante integrante = grupo.getIntegrante(dni);
        ViewBag.Integrante = integrante;
        ViewBag.Dni = dni;
        Integrante infoIntegrante = integrante;
        return View("infoIntegrante");
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
