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
    public class AppClientService : AppServiceBase<Client>, IAppClientService
    {
         private readonly IClientService _clientService;

         public AppClientService(IClientService clientService)
             : base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> ObterClientesEspeciais()
        {
            return _clientService.ObterClientesEspeciais(_clientService.GetAll());
        }
    }
}
