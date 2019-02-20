using AspNetMvc.Application.Interface;
using AspNetMvc.Domain.Entities;
using AspNetMvc.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Application.Service
{
    public class AppProductService : AppServiceBase<Product>, IAppProductService
    {
        private readonly IProductService _productService;

        public AppProductService(IProductService productService)
            : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return _productService.SearchByName(name);
        }
    }
}
