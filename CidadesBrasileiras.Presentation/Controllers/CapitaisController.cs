﻿using CidadesBrasileiras.Core.Services;
using CidadesBrasileiras.Infrastructure.Data;
using CidadesBrasileiras.Infrastructure.Repositories;
using CidadesBrasileiras.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CidadesBrasileiras.Presentation.Controllers
{
    public class CapitaisController : Controller
    {
        private readonly IMunicipioService _municipioService;

        public CapitaisController(IMunicipioService municipioService)
        {
            _municipioService = municipioService;
        }

        public async Task<IActionResult> Index()
        {
            var resultado = await _municipioService.ProcurarCapitais();
            return View(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> ProcurarCapitais()
        {
            var resultado = await _municipioService.ProcurarCapitais();

            return View("Index", resultado);
        }
    }
}
