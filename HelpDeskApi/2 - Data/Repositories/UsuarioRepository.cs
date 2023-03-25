using HelpDeskApi.Domain.Models;
using Microsoft.EntityFrameworkCore;



namespace HelpDeskApi._2___Data.Repositories
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        private readonly DbContext _dbContext;

        public UsuarioRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _dbContext.Set<Usuario>();
        }

        public Usuario GetById(Guid id)
        {
            return _dbContext.Set<Usuario>().SingleOrDefault(u => u.Id == id);
        }

        public void Add(Usuario usuario)
        {
            _dbContext.Set<Usuario>().Add(usuario);
            _dbContext.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _dbContext.Set<Usuario>().Update(usuario);
            _dbContext.SaveChanges();
        }
       
        public void Remove(Usuario usuario)
        {
            _dbContext.Set<Usuario>().Remove(usuario);
            _dbContext.SaveChanges();
        }

        object IRepository<Usuario>.GetAll()
        {
            throw new NotImplementedException();
        }

        object IRepository<Usuario>.GetById(Guid id)
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
