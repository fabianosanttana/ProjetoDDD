using AspNetMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMvc.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.idProduct);

            Property(p => p.name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.value)
                .IsRequired();

            HasRequired(p => p.client)
                .WithMany()
                .HasForeignKey(p => p.idClient);
        }
    }
}
