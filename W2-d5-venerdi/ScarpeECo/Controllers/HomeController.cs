using Microsoft.AspNetCore.Mvc;
using ScarpeCo.Interfaccia.Models; 

namespace ScarpeCo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticoloService _prodottoService; 

        public HomeController(ILogger<HomeController> logger, IArticoloService articoloService)
        {
            _logger = logger;
            _prodottoService = articoloService;
        }

        public IActionResult Index()
        {
            var products = _prodottoService.GetAllArticoli();
            return View(products); 
        }

        public IActionResult Details(int id)
        {
            var product = _prodottoService; 
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}