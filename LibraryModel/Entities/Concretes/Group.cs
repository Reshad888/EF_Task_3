using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class Group : BaseEntity
{
    // Properties
    public string Name { get; set; }

    // Navigation Properties
    public virtual ICollection<Student> Students { get; set; }
}