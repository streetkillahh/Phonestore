using Microsoft.AspNetCore.Mvc;

namespace Phonestore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
