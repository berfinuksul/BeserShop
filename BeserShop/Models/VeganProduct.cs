using System.ComponentModel.DataAnnotations;

namespace BeserShop.Models
{
    public class VeganProduct
    {
        [Key]
        public int VeganProductID { get; set; }
        [Required]
        [StringLength(50)]
        public string VeganProductName { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Price limit exceeded!")]
        public int VeganProductPrice { get; set; }
        [Required]
        public int VeganProductStock { get; set; }
        [Required]
        [StringLength(100)]
        public string VeganProductDescription { get; set; }
    }
}
