using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Category
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
