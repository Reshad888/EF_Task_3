using LibraryModel.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAccess.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(a => a.FirstName)
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        builder.Property(a => a.LastName)
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        builder.HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GroupId)
            .IsRequired();
    }
}