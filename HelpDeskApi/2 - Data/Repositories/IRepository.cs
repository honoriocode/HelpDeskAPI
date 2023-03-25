namespace HelpDeskApi._2___Data.Repositories
{
    public interface IRepository<T>
    {
        object GetAll();
        object GetById(Guid id);
        void Remove(object usuario);
        void Update(object usuario);
    }
}