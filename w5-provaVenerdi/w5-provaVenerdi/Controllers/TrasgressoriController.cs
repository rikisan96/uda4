using Microsoft.AspNetCore.Mvc;

namespace w5_provaVenerdi.Controllers
{
    public class TrasgressoriController : Controller
    {
        public IActionResult Index()
        {

            var trasgressori = new List<Trasgressore>();
            return View(trasgressori); // Passa la lista alla vista

        }

        public IActionResult Trasgressori()
        {
            return View();
        }


    }
}
