using System;
using System.Collections.Generic;

namespace ProductsCatalogApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Image> Images { get; set; }
    }
}