using LibraryModel.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace LibraryAccess.Contexts;

internal class LibraryContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source = DESKTOP-RH41O1K\\SQLEXPRESS;" +
            "Initial Catalog = LibraryDb_1;" +
            "Integrated Security = True;" +
            "Connect Timeout = 30;" +
            "Encrypt = True;" +
            "Trust Server Certificate = True;" +
            "Application Intent = ReadWrite;" +
            "Multi Subnet Failover = False";

        optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies(true);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<T_Card> T_Cards { get; set; }
    public virtual DbSet<S_Card> S_Cards { get; set; }
}