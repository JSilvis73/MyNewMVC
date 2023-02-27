using Microsoft.AspNetCore.Mvc;

namespace MyNewMVCS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
