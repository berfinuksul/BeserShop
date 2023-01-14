using BeserShop.Data;
using BeserShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SupplierController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.Suppliers.ToList(); //sql deki tablo ismimiz derneks olduğu için yazdık.
            return View(List);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            _db.Add(supplier);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id) // ? işareti koyma nedenimiz null geçilebilir demek.
        {
            var update = _db.Suppliers.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Supplier supplier)
        {
            _db.Update(supplier);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.Suppliers.FirstOrDefault(m => m.SupplierID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var delete = _db.Suppliers.FirstOrDefault(m => m.SupplierID == id);
            _db.Suppliers.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
