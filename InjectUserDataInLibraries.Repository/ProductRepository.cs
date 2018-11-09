using InjectUserDataInLibraries.Models.Abstract;
using System.Collections.Generic;
using InjectUserDataInLibraries.Models;

namespace InjectUserDataInLibraries.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IUserData _userData;

        public ProductRepository(IUserData userData)
        {
            _userData = userData;
        }

        public IEnumerable<Product> Get()
        {
            System.Diagnostics.Debug.WriteLine(_userData.UserName);
            System.Diagnostics.Debug.WriteLine(_userData.UserId);

            return new List<Product>() { new Product() { Id = 1, Name = "Name" } };
        }
    }
}
