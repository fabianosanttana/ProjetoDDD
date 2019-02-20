using AspNetMvc.Domain.Entities;
using System.Collections.Generic;

namespace AspNetMvc.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
