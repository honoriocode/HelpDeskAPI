using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data;
using HelpDeskApi.Domain.Models;
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