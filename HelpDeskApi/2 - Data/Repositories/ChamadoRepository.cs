using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data;
using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelpDeskApi.Infrastructure.Repositories
{
    public class ChamadoRepository : IRepository<Chamado>
    {
        private readonly HelpDeskContext _context;

        public ChamadoRepository(HelpDeskContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Chamado>> GetAllAsync()
        {
            return await _context.Chamados.ToListAsync();
        }

        public async Task<Chamado> GetByIdAsync(Guid id)
        {
            return await _context.Chamados.FindAsync(id);
        }

        public async Task CreateAsync(Chamado chamado)
        {
            await _context.Chamados.AddAsync(chamado);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Chamado chamado)
        {
            _context.Chamados.Update(chamado);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var chamado = await GetByIdAsync(id);
            _context.Chamados.Remove(chamado);
            await _context.SaveChangesAsync();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(object usuario)
        {
            throw new NotImplementedException();
        }

        public void Update(object usuario)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Chamado>> IRepository<Chamado>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Chamado>> GetManyWhere(Expression<Func<Usuario, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<Chamado> GetOneWhere(Expression<Func<Usuario, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<Chamado> Add(Chamado entidade)
        {
            throw new NotImplementedException();
        }

        public void Update(Chamado entidade)
        {
            throw new NotImplementedException();
        }

        public void Remove(Chamado entidade)
        {
            throw new NotImplementedException();
        }
    }
}

