using AspNetMvc.Domain.Entities;
using AspNetMvc.Domain.Interfaces.Repositories;
using AspNetMvc.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
            :base (clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> ObterClientesEspeciais(IEnumerable<Client> clients)
        {
            return clients.Where(c => c.SpecialClient(c));
        }
    }
}
