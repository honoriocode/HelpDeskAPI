using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDeskApi._2___Data.Mappings;

public sealed class EquipamentoMap : IEntityTypeConfiguration<Equipamento>
{
    public void Configure(EntityTypeBuilder<Equipamento> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Ignore(e => e.Notifications);

        builder.HasOne(e => e.Local)
            .WithMany(l => l.Equipamentos)
            .HasForeignKey(e => e.LocalId);

        builder.OwnsOne(e => e.Fornecedor, fornecedor =>
        {
            fornecedor.Property(f => f.Nome)
            .HasColumnName("NomeFornecedor")
            .HasColumnType("varchar(150)");

            fornecedor.OwnsOne(f => f.CNPJ, cnpj =>
            {
                cnpj.Property(c => c.Numero)
                .HasColumnName("CnpjFornecedor")
                .HasColumnType("varchar(14)");

                cnpj.Ignore(f => f.Notifications);
            });

            fornecedor.Ignore(f => f.Notifications);
        });
    }
}