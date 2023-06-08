namespace Data.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProductName { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = decimal.Zero;
        public int QuantityInStock { get; set; }
        public Guid SupplierID { get; set; } = new Guid();
    }
}