using System.ComponentModel.DataAnnotations;

namespace BeserShop.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        [Required]
        [StringLength(50)]
        public string SupplierName { get; set; }
        [Required]
        [StringLength(50)]
        public string SupplierAdress { get; set;}
        [Required]
        [StringLength(11)]
        public string SupplierPhone { get; set;}
    
    }
}
