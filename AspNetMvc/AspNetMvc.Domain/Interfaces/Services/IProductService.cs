using AspNetMvc.Domain.Entities;
using System.Collections.Generic;

namespace AspNetMvc.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
