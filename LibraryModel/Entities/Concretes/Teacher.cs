using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class Teacher : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Properties
    public virtual ICollection<T_Card> T_Cards { get; set; }
}