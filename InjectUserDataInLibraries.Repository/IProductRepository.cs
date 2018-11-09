using InjectUserDataInLibraries.Models;
using System.Collections.Generic;

namespace InjectUserDataInLibraries.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
    }
}
