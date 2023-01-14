using BeserShop.Data;
using BeserShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class AVeganProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AVeganProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.VeganProducts.ToList(); //sql deki tablo ismimiz derneks olduğu için yazdık.
            return View(List);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VeganProduct veganProduct)
        {
            _db.Add(veganProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id) // ? işareti koyma nedenimiz null geçilebilir demek.
        {
            var update = _db.VeganProducts.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(int? id, VeganProduct veganProduct)
        {
            _db.Update(veganProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.VeganProducts.FirstOrDefault(m => m.VeganProductID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var delete = _db.VeganProducts.FirstOrDefault(m => m.VeganProductID == id);
            _db.VeganProducts.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
