using HelpDesk.Infrastructure.Repositories;
using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data;
using HelpDeskApi.Data.Repositories;
using HelpDeskApi.Domain.Models;
using HelpDeskApi.Infrastructure.Repositories;
using HelpDeskApi.Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(
    typeof(ChamadoProfile), 
    typeof(UsuarioProfile), 
    typeof(EquipamentoProfile), 
    typeof(LocalProfile),
    typeof(TipoUsuarioProfile)
    );

var connectionString = builder.Configuration.GetConnectionString("HelpDeskConnection");
builder.Services.AddDbContext<HelpDeskContext>(
    opt => opt.UseMySql(connectionString, 
    ServerVersion.AutoDetect(connectionString))
    );

builder.Services.AddScoped<HelpDeskContext>();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IRepository<Usuario>, UsuarioRepository>();

builder.Services.AddScoped<ITipoUsuarioService, TipoUsuarioService>();
builder.Services.AddScoped<IRepository<TipoUsuario>, TipoUsuarioRepository>();

builder.Services.AddScoped<ILocalService, LocalService>();
builder.Services.AddScoped<IRepository<Local>, LocalRepository>();

builder.Services.AddScoped<IEquipamentoService, EquipamentoService>();
builder.Services.AddScoped<IRepository<Equipamento>, EquipamentoRepository>();

builder.Services.AddScoped<IChamadoService, ChamadoService>();
builder.Services.AddScoped<IRepository<Chamado>, ChamadoRepository>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(cors =>
{
    cors.AllowAnyHeader();
    cors.AllowAnyMethod();
    cors.AllowAnyOrigin();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();