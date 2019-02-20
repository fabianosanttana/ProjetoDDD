using AspNetMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace AspNetMvc.Infra.Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.idClient);

            Property(c => c.name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.lastName)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.email)
                .IsRequired();
        }
    }
}
