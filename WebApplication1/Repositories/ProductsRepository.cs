using System;
using WebApplication1.DataContext;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        
        public List<Products> GetProducts()
        {
            using (var context = new EFCoreInMemoryDb())
            {
                var list = context.Products.ToList();
                return list;
            }
        }

        public void AddProduct(Products product)
        {
            using (var context = new EFCoreInMemoryDb())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
