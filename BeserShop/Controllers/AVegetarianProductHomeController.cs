using BeserShop.Data;
using BeserShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class AVegetarianProductHomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AVegetarianProductHomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Listele = _db.VegetarianProducts.ToList(); //sql deki tablo ismimiz derneks olduğu için yazdık.
            return View(Listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VegetarianProduct vegetarianProduct)
        {
            _db.Add(vegetarianProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id) // ? işareti koyma nedenimiz null geçilebilir demek.
        {
            var yenile = _db.VegetarianProducts.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int? id, VegetarianProduct vegetarianProduct)
        {
            _db.Update(vegetarianProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.VegetarianProducts.FirstOrDefault(m => m.VegetarianProductID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var delete = _db.VegetarianProducts.FirstOrDefault(m => m.VegetarianProductID == id);
            _db.VegetarianProducts.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
