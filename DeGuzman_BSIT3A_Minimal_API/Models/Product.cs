namespace DeGuzman_BSIT3A_Minimal_API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } //Column Name
        public string Description { get; set; } //Column Description
        public decimal Price { get; set; } //Column Price
        public int Stock { get; set; } //Column for stock

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}