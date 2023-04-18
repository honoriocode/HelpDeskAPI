using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelpDeskApi.Data.Repositories
{
    public class LocalRepository : IRepository<Local>
    {
        private readonly HelpDeskContext _context;

        public LocalRepository(HelpDeskContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Local>> ObterTodos()
        {
            return await _context.Locais.ToListAsync();
        }

        public async Task<Local> ObterPorId(Guid id)
        {
            return await _context.Locais.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Inserir(Local local)
        {
            await _context.Locais.AddAsync(local);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Local local)
        {
            _context.Entry(local).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Guid id)
        {
            var local = await ObterPorId(id);
            _context.Locais.Remove(local);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
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

        //implementar o async e fazer igual esse método getall nos outros repositories
        async Task<IEnumerable<Local>> IRepository<Local>.GetAll()
        {
            var locais = await _context.Locais.ToListAsync();
            return await Task.FromResult<IEnumerable<Local>>(locais);
        }

        public Task<IEnumerable<Local>> GetManyWhere(Expression<Func<Usuario, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<Local> GetOneWhere(Expression<Func<Usuario, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<Local> Add(Local entidade)
        {
            throw new NotImplementedException();
        }

        public void Update(Local entidade)
        {
            throw new NotImplementedException();
        }

        public void Remove(Local entidade)
        {
            throw new NotImplementedException();
        }
    }
}

