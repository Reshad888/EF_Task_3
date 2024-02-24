using LibraryModel.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAccess.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(b => b.Name)
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        builder.Property(b => b.PageCount)
            .HasColumnType("int")
            .IsRequired();

        builder.Property(b => b.YearPress)
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(a => a.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(a => a.AuthorId)
            .IsRequired();
    }
}