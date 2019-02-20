using AspNetMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Application.Interface
{
    public interface IAppClientService : IAppServiceBase<Client>
    {
        IEnumerable<Client> ObterClientesEspeciais();
    }
}
