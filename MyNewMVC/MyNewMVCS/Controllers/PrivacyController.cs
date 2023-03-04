using Microsoft.AspNetCore.Mvc;

namespace MyNewMVCS.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
