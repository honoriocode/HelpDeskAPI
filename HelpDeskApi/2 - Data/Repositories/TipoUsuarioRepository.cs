    using Microsoft.EntityFrameworkCore;
using HelpDeskApi._2___Data.Repositories;
using System.Linq.Expressions;
using HelpDeskApi.Domain.Models;

namespace HelpDeskApi.Data.Repositories
{
    public class TipoUsuarioRepository : IRepository<TipoUsuario>
    {
        private readonly HelpDeskContext _context;

        public TipoUsuarioRepository(HelpDeskContext context)
        {
            _context = context;
        }

        public IEnumerable<TipoUsuario> GetAll()
        {
            return _context.Set<TipoUsuario>();
        }

        public TipoUsuario GetById(Guid id)
        {
            return _context.Set<TipoUsuario>().SingleOrDefault(tu => tu.Id == id);
        }

        public void Add(TipoUsuario tipoUsuario)
        {
            _context.Set<TipoUsuario>().Add(tipoUsuario);
            _context.SaveChanges();
        }

        public void Update(TipoUsuario tipoUsuario)
        {
            _context.Set<TipoUsuario>().Update(tipoUsuario);
            _context.SaveChanges();
        }

        public void Remove(TipoUsuario tipoUsuario)
        {
            _context.Set<TipoUsuario>().Remove(tipoUsuario);
            _context.SaveChanges();
        }

        Task<IEnumerable<TipoUsuario>> IRepository<TipoUsuario>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoUsuario>> GetManyWhere(Expression<Func<Usuario, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<TipoUsuario> GetOneWhere(Expression<Func<Usuario, bool>> condition)
        {
            throw new NotImplementedException();
        }

        Task<TipoUsuario> IRepository<TipoUsuario>.Add(TipoUsuario entidade)
        {
            throw new NotImplementedException();
        }
    }
}

