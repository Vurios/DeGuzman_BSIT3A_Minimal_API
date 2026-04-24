using DeGuzman_BSIT3A_Minimal_API.Models;

namespace DeGuzman_BSIT3A_Minimal_API.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}