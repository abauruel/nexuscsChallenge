using System.Data.Entity.ModelConfiguration;
using NexuscsChallenge.domain.Entities;

namespace NexuscsCalenge.Infraestrutura.data.EntityConfig
{
    public class ClienteConfiguration: EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClientId);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c=> c.SobreNome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();


        }
    }
}
