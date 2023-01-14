using System.ComponentModel.DataAnnotations;

namespace BeserShop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerEmail { get; set; }
        [Required]
        [StringLength(11)]
        public string CustomerPhone { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerAdress { get; set; }
    }
}
