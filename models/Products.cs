namespace ProductApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public string? Barcode { get; set; }
    }
}
