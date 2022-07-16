using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? Status { get; set; }
        public short BrandId { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; } 

        public virtual Brand Brand { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
