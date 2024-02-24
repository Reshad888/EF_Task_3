using LibraryModel.Entities.Abstracts;

namespace LibraryModel.Entities.Concretes;

public class Book : BaseEntity
{
    // Properties
    public string Name { get; set; }
    public int PageCount { get; set; }
    public int YearPress { get; set; }

    // Foreign Keys
    public int AuthorId { get; set; }

    // Navigation Properties
    public virtual Author Author { get; set; }
}