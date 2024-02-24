using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class Student : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Foreign Keys
    public int GroupId { get; set; }

    // Navigation Properties
    public virtual Group Group { get; set; }
    public virtual ICollection<S_Card> S_Cards { get; set; }
}