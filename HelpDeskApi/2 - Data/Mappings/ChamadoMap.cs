using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDeskApi._2___Data.Mappings;

public sealed class ChamadoMap : IEntityTypeConfiguration<Chamado>
{
    public void Configure(EntityTypeBuilder<Chamado> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Ignore(c => c.Notifications);

        builder.HasOne(c => c.Local)
           .WithMany(l => l.Chamados)
           .HasForeignKey(c => c.LocalId);

        builder.HasOne(c => c.Usuario)
           .WithMany(u => u.Chamados)
           .HasForeignKey(c => c.UsuarioId);

        builder.OwnsOne(c => c.Descricao, descricao =>
        {
            descricao.Property(d => d.Texto)
            .HasColumnName("Descricao")
            .HasColumnType("varchar(150)");

            descricao.Ignore(d => d.Notifications);
        });

        builder.OwnsOne(c => c.Detalhes, detalhes =>
        {
            detalhes.Property(d => d.SubstituidoPor)
            .HasColumnName("SubstituidoPor")
            .HasColumnType("varchar(150)");

            detalhes.Property(d => d.LocalAnterior)
           .HasColumnName("LocalAnterior")
           .HasColumnType("varchar(150)");

            detalhes.Property(d => d.Equipamento)
           .HasColumnName("Equipamento")
           .HasColumnType("varchar(150)");

            detalhes.Property(d => d.QualTecnico)
           .HasColumnName("QualTecnico")
           .HasColumnType("varchar(150)");

            detalhes.Property(d => d.Solucao)
           .HasColumnName("Solucao")
           .HasColumnType("varchar(150)");

            detalhes.Ignore(d => d.Notifications);
        });
    }
}