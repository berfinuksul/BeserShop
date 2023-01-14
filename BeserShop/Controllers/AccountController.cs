using Microsoft.AspNetCore.Mvc;

namespace BeserShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
