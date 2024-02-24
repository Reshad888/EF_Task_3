using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class S_Card : BaseEntity
{
    // Properties
    public DateTime DateOut { get; set; }
    public DateTime? DateIn { get; set; }

    // Foreign Keys
    public int StudentId { get; set; }

    // Navigation Properties
    public virtual Student Student { get; set; }
}