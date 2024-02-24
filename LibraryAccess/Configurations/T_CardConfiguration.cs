using LibraryModel.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAccess.Configurations;

public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        builder.Property(sc => sc.DateOut)
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(sc => sc.DateIn)
            .HasColumnType("datetime");

        builder.HasOne(tc => tc.Teacher)
            .WithMany(t => t.T_Cards)
            .HasForeignKey(tc => tc.TeacherId)
            .IsRequired();
    }
}