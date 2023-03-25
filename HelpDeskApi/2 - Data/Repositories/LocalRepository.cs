using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}

