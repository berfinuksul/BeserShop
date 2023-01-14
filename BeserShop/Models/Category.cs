﻿using System.ComponentModel.DataAnnotations;

namespace BeserShop.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
