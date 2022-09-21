using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("DataSource=SQLite.db;Cache=Shared");
    }
}