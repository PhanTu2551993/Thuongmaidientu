using System.ComponentModel.DataAnnotations;

namespace Thuongmaidientu.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required, StringLength(50)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = true;
        public List<Product>? Products { get; set; }
    }
}
