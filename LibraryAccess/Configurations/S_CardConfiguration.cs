using LibraryModel.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAccess.Configurations;

public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        builder.Property(sc => sc.DateOut)
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(sc => sc.DateIn)
            .HasColumnType("datetime");

        builder.HasOne(sc => sc.Student)
            .WithMany(s => s.S_Cards)
            .HasForeignKey(sc => sc.StudentId)
            .IsRequired();
    }
}