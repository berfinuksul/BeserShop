using BeserShop.Data;
using BeserShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BeserShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.Customers.ToList(); //sql deki tablo ismimiz derneks olduğu için yazdık.
            return View(List);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _db.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id) // ? işareti koyma nedenimiz null geçilebilir demek.
        {
            var update = _db.Customers.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Customer customer)
        {
            _db.Update(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.Customers.FirstOrDefault(m => m.CustomerID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var delete = _db.Customers.FirstOrDefault(m => m.CustomerID == id);
            _db.Customers.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
