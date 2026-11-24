using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExerciciosASP_NET_CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExerciciosASP_NET_CORE_MVC.Controllers
{

    public class EventosController : Controller
    {

        public IActionResult Index()
        {
            return View(eventos);
        }

        public static List<Evento> eventos = new List<Evento>();

        [HttpGet]

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Criar(Evento evento)
        {
            if (!ModelState.IsValid)
            {
                return View(evento);
            }

            if (eventos.Any())
            {
                evento.Id = eventos.Max(e => e.Id) + 1;
            }
            else                                      
            {
                evento.Id = 1;
            }

            
            eventos.Add(evento);

            
            return RedirectToAction("Index");

        }

    }
}