using AspNetMvc.Domain.Entities;
using AspNetMvc.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Infra.Data.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> SearchByName(string name)
        {
            return db.Products.Where(p => p.name == name);
        }
    }
}
