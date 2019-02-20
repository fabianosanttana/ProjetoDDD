using AspNetMvc.Application.Interface;
using AspNetMvc.Application.Service;
using AspNetMvc.Domain.Interfaces.Repositories;
using AspNetMvc.Domain.Interfaces.Services;
using AspNetMvc.Domain.Services;
using AspNetMvc.Infra.Data.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc.MVCProject.IoC
{
    public class ModulosNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IAppClientService>().To<AppClientService>();
            Bind<IAppProductService>().To<AppProductService>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClientService>().To<ClientService>();
            Bind<IProductService>().To<ProductService>();

            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClientRepository>().To<ClientRepository>();
            Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}