using AspNetMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Application.Interface
{ 
    public interface IAppProductService : IAppServiceBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
