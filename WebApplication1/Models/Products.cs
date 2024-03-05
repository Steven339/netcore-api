namespace WebApplication1.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PriceWithDiscount { get; set; }
        public string DiscountType { get; set; }
        public int Stock { get; set; }
    }
}
