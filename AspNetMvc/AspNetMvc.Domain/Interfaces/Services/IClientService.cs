using AspNetMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> ObterClientesEspeciais(IEnumerable<Client> clients);
    }
}
