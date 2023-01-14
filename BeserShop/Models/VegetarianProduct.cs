using System.ComponentModel.DataAnnotations;

namespace BeserShop.Models
{
    public class VegetarianProduct
    {
       
        [Key]
        public int VegetarianProductID { get; set; }
        [Required]
        [StringLength(50)]
        public string VegetarianProductName { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Price limit exceeded!")]
        public int VegetarianProductPrice { get; set; }
        [Required]
        public int VegetarianProductStock { get; set; }
        [Required]
        [StringLength(100)]
        public string VegetarianProductDescription { get; set; }
    }
}
