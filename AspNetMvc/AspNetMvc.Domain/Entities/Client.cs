using System;
using System.Collections.Generic;

namespace AspNetMvc.Domain.Entities
{
    public class Client
    {
        public int idClient { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateRecorder { get; set; }
        public bool active { get; set; }
        public virtual IEnumerable<Product> Produtos { get; set; }

        public bool SpecialClient(Client client)
        {
            return client.active && DateTime.Now.Year - client.dateRecorder.Year >= 5;
        }
    }
}
