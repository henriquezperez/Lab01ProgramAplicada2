using Lab1.BusinessLogic;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(ActionNotas notas)
        {
            OperacionesNotas op = new OperacionesNotas();
            Double Laboratorios = op.SumaLab(notas);
            Double Paraciales = op.SumaPar(notas);
            Double Promedio = op.Prom(notas);
            ViewBag.Nombre = notas.Nombre;
            ViewBag.Lab1 = notas.Lab1;
            ViewBag.Lab2 = notas.Lab2;
            ViewBag.Lab3 = notas.Lab3;
            ViewBag.Par1 = notas.Par1;
            ViewBag.Par2 = notas.Par2;
            ViewBag.Par3 = notas.Par3;
            ViewBag.Prom = notas.Prom;
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
    }
}