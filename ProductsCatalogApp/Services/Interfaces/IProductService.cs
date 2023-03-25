﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsCatalogApp.Models;

namespace ProductsCatalogApp.Services
{
    public interface IProductService
    {
        Task<Product> GetAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(int id, Product product);
        Task<bool> DeleteAsync(int id);
    }
}