﻿using TaNaCesta.Domain.Entities;

namespace TaNaCesta.Domain.Interfaces
{
    public interface IProductRepository : IDisposable
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Task<Category> GetCategoryById(int id);
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetAllProducts();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
    }
}
