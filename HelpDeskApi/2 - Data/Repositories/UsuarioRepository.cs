using HelpDeskApi.Data;
using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelpDeskApi._2___Data.Repositories;

public class UsuarioRepository : IRepository<Usuario>
{
    private readonly HelpDeskContext _dbContext;
    private readonly DbSet<Usuario> _dbSet;

    public UsuarioRepository(HelpDeskContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<Usuario>();
    }

    public async Task<IEnumerable<Usuario>> GetAll()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }


    public async Task<IEnumerable<Usuario>> GetManyWhere(Expression<Func<Usuario, bool>> condition)
    {
        return await _dbSet.Where(condition).ToListAsync();
    }

    public async Task<Usuario> GetOneWhere(Expression<Func<Usuario, bool>> condition)
    {
        return (await _dbSet.SingleOrDefaultAsync(condition))!;
    }

    public async Task<Usuario> Add(Usuario usuario)
    {
        await _dbSet.AddAsync(usuario);
        _dbContext.SaveChanges();
        return usuario;
    }

    public void Update(Usuario usuario)
    {
        _dbSet.Update(usuario);
        _dbContext.SaveChanges();
    }

    public void Remove(Usuario usuario)
    {
        _dbSet.Remove(usuario);
        _dbContext.SaveChanges();
    }
}