using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApi.Data
{
    public class HelpDeskContext : DbContext
    {
        public HelpDeskContext(DbContextOptions<HelpDeskContext> options) : base(options) 
        { 

        } 

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Chamado> Chamados { get; set; }


    }
}
