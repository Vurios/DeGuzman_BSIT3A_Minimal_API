using DeGuzman_BSIT3A_Minimal_API.Models;

namespace DeGuzman_BSIT3A_Minimal_API.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}