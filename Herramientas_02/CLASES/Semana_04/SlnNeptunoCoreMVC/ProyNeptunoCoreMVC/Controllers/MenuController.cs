using Microsoft.AspNetCore.Mvc;

namespace ProyNeptunoCoreMVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
