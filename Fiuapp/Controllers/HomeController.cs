using Microsoft.AspNetCore.Mvc;

namespace Fiuapp.Controlles
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContacUs()
        {
            return View();
        }
    }
}
