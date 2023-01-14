using BeserShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BeserShop.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //her türlü bağlantı yapsın diye yapıyoruz.
        }
        //tablomuzu ekliyoruz.
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<VeganProduct> VeganProducts { get; set; }
        public virtual DbSet<VegetarianProduct> VegetarianProducts { get; set; }
        public virtual DbSet<MeatProduct> MeatProducts { get; set; }


    }
}
