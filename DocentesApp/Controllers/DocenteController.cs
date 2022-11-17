using Microsoft.AspNetCore.Mvc;

namespace DocentesApp.Controllers
{
    public class DocenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
