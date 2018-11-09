using InjectUserDataInLibraries.Models;
using InjectUserDataInLibraries.Repository;
using System.Collections.Generic;

namespace InjectUserDataInLibraries.Service
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }
    }
}
