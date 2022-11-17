using Microsoft.AspNetCore.Mvc;

namespace DocentesApp.Controllers
{
    public class GruposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
