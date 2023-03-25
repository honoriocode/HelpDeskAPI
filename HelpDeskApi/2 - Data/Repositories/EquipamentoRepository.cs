using HelpDeskApi._2___Data.Repositories;
using HelpDeskApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Infrastructure.Repositories
{
    public class EquipamentoRepository : IRepository<Equipamento>
    {
        private readonly HelpDeskContext _context;

        public EquipamentoRepository(HelpDeskContext context)
        {
            _context = context;
        }

        public void Add(Equipamento entity)
        {
            _context.Equipamentos.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _context.Equipamentos.Find(id);
            if (entity != null)
            {
                _context.Equipamentos.Remove(entity);
                _context.SaveChanges();
            }
        }

        public Equipamento GetById(Guid id)
        {
            return _context.Equipamentos.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Equipamento> GetAll()
        {
            return _context.Equipamentos.ToList();
        }

        public void Update(Equipamento entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        object IRepository<Equipamento>.GetAll()
        {
            throw new NotImplementedException();
        }

        object IRepository<Equipamento>.GetById(Guid id)
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

