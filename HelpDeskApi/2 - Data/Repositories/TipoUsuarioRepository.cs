using Microsoft.EntityFrameworkCore;
using HelpDeskApi._2___Data.Repositories;

namespace HelpDeskApi.Data.Repositories
{
    public class TipoUsuarioRepository : IRepository<TipoUsuario>
    {
        private readonly DbContext _dbContext;

        public TipoUsuarioRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TipoUsuario> GetAll()
        {
            return _dbContext.Set<TipoUsuario>();
        }

        public TipoUsuario GetById(Guid id)
        {
            return _dbContext.Set<TipoUsuario>().SingleOrDefault(tu => tu.Id == id);
        }

        public void Add(TipoUsuario tipoUsuario)
        {
            _dbContext.Set<TipoUsuario>().Add(tipoUsuario);
            _dbContext.SaveChanges();
        }

        public void Update(TipoUsuario tipoUsuario)
        {
            _dbContext.Set<TipoUsuario>().Update(tipoUsuario);
            _dbContext.SaveChanges();
        }

        public void Remove(TipoUsuario tipoUsuario)
        {
            _dbContext.Set<TipoUsuario>().Remove(tipoUsuario);
            _dbContext.SaveChanges();
        }
    }
}

