using HelpDeskApi.Domain.Core;
using HelpDeskApi.Domain.Models;
using System.Linq.Expressions;

namespace HelpDeskApi._2___Data.Repositories;

public interface IRepository<TEntidade> where TEntidade : Entidade
{
    Task<IEnumerable<TEntidade>> GetAll();
    Task<IEnumerable<TEntidade>> GetManyWhere(Expression<Func<Usuario, bool>> condition);
    Task<TEntidade> GetOneWhere(Expression<Func<Usuario, bool>> condition);

    Task<TEntidade> Add(TEntidade entidade);
    void Update(TEntidade entidade);
    void Remove(TEntidade entidade);
}