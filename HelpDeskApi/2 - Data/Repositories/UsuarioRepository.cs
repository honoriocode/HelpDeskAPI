using Microsoft.EntityFrameworkCore;
using HelpDeskApi.Domain.Models;



namespace HelpDeskApi._2___Data.Repositories
{
    public class UsuarioRepository : IRepository<Domain.Models.Usuario>
    {
        private readonly DbContext _dbContext;

        public bool IsFailed { get; internal set; }

        public UsuarioRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UsuarioRepository()
        {
        }

        public IEnumerable<Domain.Models.Usuario> GetAll()
        {
            return _dbContext.Set<Domain.Models.Usuario>();
        }

        public Domain.Models.Usuario GetById(Guid id)
        {
            return _dbContext.Set<Usuario>().SingleOrDefault(u => u.Id == id);
        }

        public void Add(Domain.Models.Usuario usuario)
        {
            _dbContext.Set<Domain.Models.Usuario>().Add(usuario);
            _dbContext.SaveChanges();
        }

        public void Update(Domain.Models.Usuario usuario)
        {
            _dbContext.Set<Domain.Models.Usuario>().Update(usuario);
            _dbContext.SaveChanges();
        }
       
        public void Remove(Domain.Models.Usuario usuario)
        {
            _dbContext.Set<Domain.Models.Usuario>().Remove(usuario);
            _dbContext.SaveChanges();
        }

        object IRepository<Domain.Models.Usuario>.GetAll()
        {
            throw new NotImplementedException();
        }

        object IRepository<Domain.Models.Usuario>.GetById(Guid id)
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
