using LibraryModel.Entities.Abstracts;

namespace LibraryAccess.Repostories.Abstracts;

public interface IBaseRepostory<T> where T : BaseEntity, new()
{
    void Add(T entity);

    void Delete(T entity);

    void Update(T entity);

    ICollection<T> GetAll(int id);

    void Save();
}