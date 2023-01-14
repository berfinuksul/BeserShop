using Microsoft.AspNetCore.Mvc;

namespace BeserShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
