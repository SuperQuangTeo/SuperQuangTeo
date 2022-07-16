using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class ProductCategory
    {
        public short Id { get; set; }
        public short ProductId { get; set; }
        public short CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
