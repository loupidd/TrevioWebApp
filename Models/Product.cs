namespace TrevioWepApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, decimal price, string imageUrl, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Category = category;
        }
    }
}
