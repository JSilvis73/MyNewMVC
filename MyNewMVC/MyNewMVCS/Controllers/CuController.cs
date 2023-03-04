using Microsoft.AspNetCore.Mvc;

namespace MyNewMVCS.Controllers
{
    public class CuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
