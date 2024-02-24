using LibraryAccess.Contexts;
using LibraryAccess.Repostories.Abstracts;
using LibraryModel.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace LibraryAccess.Repostories.Concretes;

public class BaseRepostory<T> : IBaseRepostory<T> where T : BaseEntity, new()
{
    internal readonly LibraryContext libraryContext;
    internal readonly DbSet<T> _entity;

    public BaseRepostory()
    {
        libraryContext = new LibraryContext();
        _entity = libraryContext.Set<T>();
    }

    public void Add(T entity)
    {
        _entity.Add(entity);
    }

    public void Delete(T entity)
    {
        _entity.Remove(entity);
    }

    public ICollection<T> GetAll(int id)
    {
        return _entity.ToList();
    }

    public void Update(T entity)
    {
        _entity.Update(entity);
    }

    public void Save()
    {
        libraryContext.SaveChanges();
    }
}