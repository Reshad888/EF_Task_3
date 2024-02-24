namespace LibraryModel.Entities.Abstracts;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime? UpdateDate { get; set; }
}