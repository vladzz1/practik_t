namespace PD411_Shop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public int Amount { get; set; }
        public string? Color { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Parse("2026-02-16");

        public int CategoryId { get; set; }
        public CategoryModel? Category { get; set; }
    }
}
