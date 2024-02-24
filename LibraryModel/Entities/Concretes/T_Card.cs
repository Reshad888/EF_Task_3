using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class T_Card : BaseEntity
{
    // Properties
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }

    // Foreign Keys
    public int TeacherId { get; set; }

    // Navigation Properties
    public virtual Teacher Teacher { get; set; }
}