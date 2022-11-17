using Microsoft.EntityFrameworkCore;
public class AppContext : DbContext
{
    public DbSet<Speciality> Specialities => Set<Speciality>();

    public AppContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=helperdb.db");
    }
}