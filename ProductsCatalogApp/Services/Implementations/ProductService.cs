using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsCatalogApp.Models;
using ProductsCatalogApp.Repositories;
using System.Linq;

namespace ProductsCatalogApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IPostgresRepository<Product> _repository;

        public ProductService(IPostgresRepository<Product> repository)
        {
            _repository = repository;
        }
        
        public async Task<Product> GetAsync(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var products = await _repository.GetAll();
            return products.ToList();
        }

        public async Task<Product> CreateAsync(Product product)
        {
            return await _repository.Add(product);
        }

        public async Task<Product> UpdateAsync(int id, Product product)
        {
            return await _repository.Update(id, product);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.Delete(id);
        }
    }
}