using AplicacaoLanches.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AplicacaoLanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public IActionResult Index()
        {
            TempData["Nome"] = "Nome teste no TempData";
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}