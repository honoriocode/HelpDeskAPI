using HelpDeskApi._2___Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApi._2___Data.Extensions;

public static class ModelBuilderExtensions
{
    public static void ConfigureMappings(this ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ChamadoMap());
        modelBuilder.ApplyConfiguration(new EquipamentoMap());
        modelBuilder.ApplyConfiguration(new LocalMap());
        modelBuilder.ApplyConfiguration(new TipoUsuarioMap());
        modelBuilder.ApplyConfiguration(new UsuarioMap());
    }
}