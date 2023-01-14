using BeserShop.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class MeatProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MeatProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.MeatProducts.ToList();
            return View(List);
        }
    }
}
