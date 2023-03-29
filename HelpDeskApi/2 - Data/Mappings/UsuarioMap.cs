using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.CompilerServices;

namespace HelpDeskApi._2___Data.Mappings;

public sealed class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Ignore(u => u.Notifications);

        builder.HasOne(u => u.TipoUsuario)
            .WithMany(t => t.Usuarios)
            .HasForeignKey(u => u.TipoUsuarioId);
    }
}