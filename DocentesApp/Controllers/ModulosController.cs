using Microsoft.AspNetCore.Mvc;

namespace DocentesApp.Controllers
{
    public class ModulosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
