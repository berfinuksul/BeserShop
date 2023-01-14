using BeserShop.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class VeganProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VeganProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.VeganProducts.ToList();
            return View(List);
        }
    }
}
