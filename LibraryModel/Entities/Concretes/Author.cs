using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class Author : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Properties
    public virtual ICollection<Book> Books { get; set; }
}