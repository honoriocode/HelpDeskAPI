using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDeskApi._2___Data.Mappings;

public sealed class TipoUsuarioMap : IEntityTypeConfiguration<TipoUsuario>
{
    public void Configure(EntityTypeBuilder<TipoUsuario> builder)
    {
        builder.HasKey(tu => tu.Id);

        builder.Ignore(tu => tu.Notifications);

        builder.OwnsOne(tu => tu.Descricao, descricao =>
        {
            descricao.Property(d => d.Texto)
            .HasColumnName("Descricao")
            .HasColumnType("varchar(150)");

            descricao.Ignore(d => d.Notifications);
        });
    }
}