using BeserShop.Data;
using BeserShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class AMeatProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AMeatProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.MeatProducts.ToList(); //sql deki tablo ismimiz derneks olduğu için yazdık.
            return View(List);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MeatProduct meatproduct)
        {
            _db.Add(meatproduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id) // ? işareti koyma nedenimiz null geçilebilir demek.
        {
            var update = _db.MeatProducts.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(int? id, MeatProduct meatproduct)
        {
            _db.Update(meatproduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.MeatProducts.FirstOrDefault(m => m.MeatProductID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var delete = _db.MeatProducts.FirstOrDefault(m => m.MeatProductID == id);
            _db.MeatProducts.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
