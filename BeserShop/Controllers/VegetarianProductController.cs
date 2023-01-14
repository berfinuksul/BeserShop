using BeserShop.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class VegetarianProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VegetarianProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.VegetarianProducts.ToList();
            return View(List);
        }
    }
}
