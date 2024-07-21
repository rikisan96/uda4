using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using w5_progettoVenerdi.Services;
using w5_progettoVenerdi.Models;
using w5_progettoVenerdi.Services.Interfaces;


namespace w5_progettoVenerdi.Controllers
{
    public class AnagraficheController : Controller
    {

        private readonly IAnagraficheService _anagraficaService;

        public AnagraficheController (IAnagraficheService anagraficheService)
        {
            _anagraficaService = anagraficheService;
        }
        public IActionResult Index()
        {
            var anagrafiche = _anagraficaService.ReadAll();
            return View(anagrafiche);
        }

        public IActionResult Dettagli(int id)
        {
            var anagrafica = _anagraficaService.Read(id);
            if (anagrafica == null)
            {
                return NotFound();
            }
            else
            {
                return View(anagrafica);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Anagrafica anagrafica)
        {
            if (id != anagrafica.IdAnagrafica)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _anagraficaService.Update(anagrafica);
                }
                catch (Exception)
                {
                    if (_anagraficaService.Read(anagrafica.IdAnagrafica) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(anagrafica);
        }
        public IActionResult Delete(int id)
        {
            var anagrafica = _anagraficaService.Read(id);
            if (anagrafica == null)
            {
                return NotFound();
            }
            return View(anagrafica);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminaInformazione(int id)
        {
            _anagraficaService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
