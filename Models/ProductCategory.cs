using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _005_beginning_ef_core.Models
{
    public class ProductCategory
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        // Navigational Properties
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
