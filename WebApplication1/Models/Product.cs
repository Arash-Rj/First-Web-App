namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Product() { }
        public Product( string name, int price, int quantity,Category category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
