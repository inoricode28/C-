using Microsoft.AspNetCore.Mvc;

namespace ec_01_Vicuñawebapp.Controllers
{
    public class MenuVicuñaEC01Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
