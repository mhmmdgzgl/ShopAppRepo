using System.Collections.Generic;

namespace ShopApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        // public int CategoryId { get; set; } // for each product,there will be a categoryID BUT instead of this, we will make that a product can have multiple categories. multiple relations -
    }
}
