namespace WebApplication1.Models
{
    public interface IProductsRepository
    {
        public List<Products> GetProducts();

        public void AddProduct(Products product);
    }
}
