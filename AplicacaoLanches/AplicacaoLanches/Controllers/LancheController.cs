using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicacaoLanches.Context;
using AplicacaoLanches.Models;
using AplicacaoLanches.Repository.InterfacesRepository;

namespace AplicacaoLanches.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _lancheRepository;


        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public async Task<IActionResult> List()
        {
            // Exemplo uso da ViewData
            // ViewData possui o tempo de vida igual a Request, para att precisa recarregar a página
            ViewData["tituloPrincipal"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            // ViewBag é parecida com a ViewData mas usa chave valor, tempo de vida igual a request
            // Exemplo de uso da ViewBag
            ViewBag.TotalTitulo = "Total de Lanches: ";
            ViewBag.TotalLanches = totalLanches;

            // TempData transfere dados do Controller para a View ou vice versa; Ou transfere dados do método
            //      Action para outro método Action no mesmo Controlador ou em um Controlador diferente
            // Importante: o TempData só recupera o valor uma vez, sendo executado pela primeira vez irá trazer o valor
            //      mas caso solicite novamente não irá trazer nada.
            var nomeTempData = TempData["Nome"];

            ViewBag.NomeTempData = nomeTempData;

            return View(lanches);
        }

    }
}
