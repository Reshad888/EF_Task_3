using LibraryModel.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAccess.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(a => a.FirstName)
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        builder.Property(a => a.LastName)
            .HasColumnType("nvarchar(max)")
            .IsRequired();
    }
}