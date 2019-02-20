using AspNetMvc.Domain.Entities;
using AspNetMvc.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace AspNetMvc.Infra.Data.Context
{
    public class ProjectContext : DbContext
    {
        //A utilização da base é para o Entity fisgar a connection string presente em 0 - Presentation
        public ProjectContext()
            :   base("ConnectionProject")
        {

        }

        //Esta linha é usada para a criação inicial da tabela de cliente no meu banco, utilizando o comando update-Database -Verbose
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        //Esta linha é usada para alterar a convenção da criação de tabelas no comando update-Database -Verbose, o entity por padrão cria os campos errados
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remoção de convenções indesejadas
            //PluralizingTableNameConvention - Criação de tabelas com nome no plural - Classe Cliente - Tabela criada Clientes
            //OneToManyCascadeDeleteConvention - Deleta em cascata ligações de 1 para muitos
            //ManyToManyCascadeDeleteConvention - Deleta em cascata ligações de muitos para muitos
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Criação de convenção para quando um campo de classe tiver com Id no fim, será declarado chave primária
            //modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());

            //Criação de convenção para quando for string, ser classificado como varchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Definindo um tamanho padrão para o campo caso não seja informado
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Método responsável por adicionar configuração de classe a startup do projeto
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }

        //Essa alteração foi feita para toda data cadastro ser inserida com a data padrão
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("dateRecorder") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("dateRecorder").CurrentValue = DateTime.Now;
                else if (entry.State == EntityState.Modified)
                    entry.Property("dateRecorder").IsModified = false;
            }
            return base.SaveChanges();
        }
    }
}
