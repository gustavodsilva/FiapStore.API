using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Repository.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnType("INT").UseIdentityColumn();
        builder.Property(p => p.DataCriacao).HasColumnName("DataCriacao").HasColumnType("DATETIME").IsRequired();
        builder.Property(p => p.Nome).HasColumnType("VARCHAR(100)").IsRequired();
        builder.Property(p => p.CPF).HasColumnType("VARCHAR(11)").IsRequired();
        builder.Property(p => p.DataNascimento).HasColumnType("DATETIME");
    }
}
