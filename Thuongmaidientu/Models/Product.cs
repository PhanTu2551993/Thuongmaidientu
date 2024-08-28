using System.ComponentModel.DataAnnotations;

namespace Thuongmaidientu.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required, StringLength(100)]
        public string ProductName { get; set; }
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        public int Stock { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string? ImageUrl { get; set; }
        public List<ProductImage>? Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
