using AspNetMvc.Domain.Entities;
using AspNetMvc.Domain.Interfaces.Repositories;
using AspNetMvc.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AspNetMvc.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return _productRepository.SearchByName(name);
        }
    }
}
