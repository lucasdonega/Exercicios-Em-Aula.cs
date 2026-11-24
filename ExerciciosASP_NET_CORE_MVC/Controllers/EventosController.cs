using ExerciciosASP_NET_CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciciosASP_NET_CORE_MVC.Controllers
{
    public class EventosController : Controller
    {
        private static readonly List<Evento> eventos = new List<Evento>();

        public IActionResult Index()
        {
            return View(eventos);
        }

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

            evento.Id = eventos.Any() ? eventos.Max(e => e.Id) + 1 : 1;
            eventos.Add(evento);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Buscar()
        {
            return View(new BuscaEventoViewModel());
        }

        [HttpPost]
        public IActionResult Buscar(BuscaEventoViewModel modelo)
        {
            var consulta = eventos.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(modelo.NomeBusca))
            {
                consulta = consulta.Where(e =>
                    e.Nome != null &&
                    e.Nome.Contains(modelo.NomeBusca, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(modelo.LocalBusca))
            {
                consulta = consulta.Where(e =>
                    e.Local != null &&
                    e.Local.Contains(modelo.LocalBusca, StringComparison.OrdinalIgnoreCase));
            }

            if (modelo.DataInicial.HasValue)
            {
                consulta = consulta.Where(e =>
                    e.DataEvento.HasValue &&
                    e.DataEvento.Value.Date >= modelo.DataInicial.Value.Date);
            }

            modelo.Resultados = consulta.ToList();
            modelo.BuscaRealizada = true;

            return View(modelo);
        }
    }
}