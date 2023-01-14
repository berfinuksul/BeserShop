using System.ComponentModel.DataAnnotations;

namespace BeserShop.Models
{
    public class MeatProduct
    {
        [Key]
        public int MeatProductID { get; set; }
        [Required]
        [StringLength(50)]
        public string MeatProductName { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Price limit exceeded!")]
        public int MeatProductPrice { get; set; }
        [Required]
        public int MeatProductStock { get;set; }
        [Required]
        [StringLength(100)]
        public string MeatProductDescription { get; set;}
    }
}
