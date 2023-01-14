using Microsoft.AspNetCore.Mvc;

namespace BeserShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
