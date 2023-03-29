using HelpDeskApi._2___Data.Extensions;
using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApi.Data
{
    public class HelpDeskContext : DbContext
    {
        public HelpDeskContext(DbContextOptions<HelpDeskContext> options)
            : base(options) 
        { } 

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<TipoUsuario> TipoUsuarios => Set<TipoUsuario>();
        public DbSet<Local> Locais => Set<Local>();
        public DbSet<Equipamento> Equipamentos => Set<Equipamento>();
        public DbSet<Chamado> Chamados => Set<Chamado>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMappings();

            base.OnModelCreating(modelBuilder);
        }
    }
}
