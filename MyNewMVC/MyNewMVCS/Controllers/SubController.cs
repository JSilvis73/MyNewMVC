using Microsoft.AspNetCore.Mvc;

namespace MyNewMVCS.Controllers
{
    public class SubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
