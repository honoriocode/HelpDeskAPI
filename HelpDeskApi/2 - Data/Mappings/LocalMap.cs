using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDeskApi._2___Data.Mappings;

public sealed class LocalMap : IEntityTypeConfiguration<Local>
{
    public void Configure(EntityTypeBuilder<Local> builder)
    {
        builder.HasKey(l => l.Id);

        builder.Ignore(l => l.Notifications);

        builder.OwnsOne(l => l.Descricao, descricao =>
        {
            descricao.Property(d => d.Texto)
            .HasColumnName("Descricao")
            .HasColumnType("varchar(150)");

            descricao.Ignore(d => d.Notifications);
        });

        builder.OwnsOne(l => l.Endereco, endereco =>
        {
            endereco.OwnsOne(d => d.CEP, cep =>
            {
                cep.Property(c => c.Numero)
                .HasColumnName("CEP")
                .HasColumnType("varchar(150)");

                cep.Ignore(c => c.Notifications);
            });

            endereco.Property(d => d.Cidade)
            .HasColumnName("Cidade")
            .HasColumnType("varchar(150)");

            endereco.Property(d => d.Bairro)
            .HasColumnName("Bairro")
            .HasColumnType("varchar(150)");

            endereco.Property(d => d.Rua)
            .HasColumnName("Rua")
            .HasColumnType("varchar(150)");

            endereco.Property(d => d.Numero)
            .HasColumnName("Numero")
            .HasColumnType("varchar(150)");

            endereco.Property(d => d.Complemento)
            .HasColumnName("Complemento")
            .HasColumnType("varchar(150)");

            endereco.Ignore(d => d.Notifications);
        });
    }
}